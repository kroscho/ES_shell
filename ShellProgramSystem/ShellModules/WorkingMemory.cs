using System.Collections.Generic;
using ShellProgramSystem.Classes;

namespace ShellProgramSystem.ShellModules
{
    public class WorkingMemory
    { 
        // Глобальная переменная цели консультации
        public Variable GlobalGoalVariable { get; private set; }

        // Список необработанных правил
        public List<Rule> UntriggeredRules { get; private set; }

        // Список известных фактов
        public List<RuleFact> KnownFacts { get; private set; }

        // Словарь, устанавливающий соответствие между переменной и правилом, 
        // из которого она была выведена (необходимо для компоненты объяснений)
        public Dictionary<Variable, Rule> InferenceRulesDict { get; private set; }


        // Конструктор
        public WorkingMemory(Variable globalGoalVariable, List<Rule> knowledgeBaseRules = null)
        {
            GlobalGoalVariable = globalGoalVariable;
            if (knowledgeBaseRules != null)
                UntriggeredRules = new List<Rule>(knowledgeBaseRules);
            else
                UntriggeredRules = new List<Rule>();
            KnownFacts = new List<RuleFact>();
            InferenceRulesDict = new Dictionary<Variable, Rule>();
        }
    }
}
