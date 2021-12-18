using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellProgramSystem.Classes;
using ShellProgramSystem.Forms;

namespace ShellProgramSystem.ShellModules
{
    class InferenceMachine
    {
        // Форма консультации, которая будет использоваться для диалога с пользователем
        private readonly FormConsultation formConsultation;
        // База знаний, на основании которой будет проводиться консультация
        private readonly KnowledgeBase knowledgeBase;
        // Объект рабочей памяти (свой для каждой сессии консультации)
        public WorkingMemory WorkingMemory { get; private set; }


        // Конструктор, создающий механизм логического вывода, использующий заданную базу знаний и форму консультации
        // <param name="knowledgeBase">База знаний, на основании которой будут проводиться консультации</param>
        // <param name="formConsultation">Форма консультации, которая будет использоваться для диалога с пользователем</param>
        public InferenceMachine(KnowledgeBase knowledgeBase, FormConsultation formConsultation)
        {
            this.formConsultation = formConsultation;
            this.knowledgeBase = knowledgeBase;
        }

        // Методы

        // Доказать заданное правило
        // <returns>Факты из заключения доказанного правила. Null, если доказать правило не удалось</returns>
        private async Task<List<RuleFact>> ProveRule(Rule rule)
        {
            // Убираем это правило из несработавших
            WorkingMemory.UntriggeredRules.Remove(rule);
            // Для каждого факта в посылке правила смотрим, известно ли значение его переменной
            foreach (var premiseFact in rule.Premise)
            {
                // Ищем известные факты с переменной этого факта посылки
                RuleFact knownFact = WorkingMemory.KnownFacts.Where(fact => fact.Variable == premiseFact.Variable).FirstOrDefault();
                DomainValue knownValue;
                // Если значение переменной этого факта посылки уже известно, берём его
                if (knownFact != null)
                    knownValue = knownFact.Value;
                // Иначе - пытаемся вычислить значение этого факта
                else
                    knownValue = await FindVariableValue(premiseFact.Variable);
                // Если факт ложный, всё - правило не доказать 
                // *Стратегия тестирования посылки - эталонная (eager) - не вычисляем все факты, если уже можно сделать вывод об истинности / ложности правила
                if (premiseFact.Value != knownValue)
                    return null;
            }
            // Запоминаем, к какому доказанному правилу относятся переменные
            foreach (var conclusionFact in rule.Conclusion)
                WorkingMemory.InferenceRulesDict[conclusionFact.Variable] = rule;
            return rule.Conclusion;
        }

        // Вычислить значение заданной переменной.
 
        // <returns>Вычисленное значение заданной переменной. Null - если переменную означить не удалось</returns>
        private async Task<DomainValue> FindVariableValue(Variable variable)
        {
            // Просматриваем уже известные факты в поисках значения заданной переменной
            foreach (var knownFact in WorkingMemory.KnownFacts)
            {
                // Если факт с этой переменной уже известен, возвращаем его значение
                if (knownFact.Variable == variable)
                    return knownFact.Value;
            }
            // Если значение переменной неизвестно, и она запрашиваемая - запрашиваем её у пользователя
            if (variable.Type == VariableType.Requested)
            {
                var variableValue = (DomainValue)await formConsultation.GetAnswerAsync(variable.QuestionText, variable.Domain.Values.ToList<object>());
                // Полученное значение переменной добавляем в известные факты, и возвращаем это значение
                WorkingMemory.KnownFacts.Add(new RuleFact(variable, Operation.Equal, variableValue));
                return variableValue;
            }
            // Получаем из несработавших правил те, которые способны означить эту переменную (т.е. содержат эту переменную в заключении)
            // *Порядок рассмотрения правил FIFO - по порядку (а не по приоритету, по наименьшему количеству неизвестных фактов в посылке и т.д.)
            List<Rule> suitableRules = new List<Rule>();
            foreach (var untriggeredRule in WorkingMemory.UntriggeredRules)
            {
                foreach (var conclusionFact in untriggeredRule.Conclusion)
                {
                    if (conclusionFact.Variable == variable)
                    {
                        suitableRules.Add(untriggeredRule);
                        break;
                    }
                }
            }
            // Пытаемся вывести значение переменной путём доказательства одного из этих правил
            foreach (var rule in suitableRules)
            {
                // Пытаемся доказать правило
                List<RuleFact> provedFacts = await ProveRule(rule);
                // Если доказали правило, то сохраняем все факты заключения в известные,
                // и возвращаем выведенное значение искомой переменной (первое, правило может несколько раз означивать одну и ту же переменную, ограничения нет)
                // *Количество рассматриваемых решений - минимальный поиск (достаточно одного решения)
                if (provedFacts != null)
                {
                    foreach (var fact in provedFacts)
                        WorkingMemory.KnownFacts.Add(fact);
                    return provedFacts.Where(fact => fact.Variable == variable).First().Value;
                }
            }
            // Если значение переменной вывести из правил не удалось, а переменная запрашиваемо-выводимая - запрашиваем значение у пользователя
            if (variable.Type == VariableType.DeducedRequested)
            {
                var variableValue = (DomainValue)await formConsultation.GetAnswerAsync(variable.QuestionText, variable.Domain.Values.ToList<object>());
                // Полученное значение переменной добавляем в известные факты, и возвращаем это значение
                WorkingMemory.KnownFacts.Add(new RuleFact(variable, Operation.Equal, variableValue));
                return variableValue;
            }
            // Иначе - вывести значение переменной не удалось
            return null;
        }

        // Начать консультацию по заданной целевой переменной. *Использовать только как асинхронный метод, т.к.
        // задание вопросов пользователю в процессе консультации может быть проведено только асинхронно.

        // <param name="goalVariable">Целевая переменная, которую необходимо означить</param>
        // <returns>Вычисленное значение целевой переменной. Null - если переменную означить не удалось</returns>
        public async Task<DomainValue> StartConsultation(Variable goalVariable)
        {
            // Создаём новый объект рабочей памяти
            WorkingMemory = new WorkingMemory(goalVariable, knowledgeBase.Rules);
            // Запускаем МЛВ
            return await FindVariableValue(goalVariable);
        }
    }
}
