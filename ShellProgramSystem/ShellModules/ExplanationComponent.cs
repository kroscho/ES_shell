using System.Collections.Generic;
using System.Windows.Forms;
using ShellProgramSystem.Classes;

namespace ShellProgramSystem.ShellModules
{
    public class ExplanationComponent
    {
        // Один и тот же узел нельзя поместить в несколько TreeView, поэтому необходимо при запросе копировать его
        private TreeNode rulesTreeRoot;
        // Дерево правил в виде корневого узла TreeNode дерева TreeView
        public TreeNode RulesTreeRoot => (TreeNode)rulesTreeRoot.Clone();
        // Список фактов, вычисленных при консультации
        public List<RuleFact> VariablesValuesList { get; private set; }


        // Конструктор, инициализирующий объяснительную компоненту ЭС по рабочей памяти консультации,
        // для которой необходимо построить объяснение
        // workingMemory - Рабочая память консультации, для которой необходимо объяснение
        public ExplanationComponent(WorkingMemory workingMemory)
        {
            // Заполняем список переменных и их значений
            FillVariablesValuesList(workingMemory);
            // Создаём дерево правил
            FillRulesTree(workingMemory, workingMemory.GlobalGoalVariable, null);
        }

        // Создать список переменных и их значений
        private void FillVariablesValuesList(WorkingMemory workingMemory)
        {
            // Просто переписываем известные факты
            VariablesValuesList = new List<RuleFact>(workingMemory.KnownFacts.Count);
            foreach (var fact in workingMemory.KnownFacts)
                VariablesValuesList.Add(fact);
        }

        // Построить дерево сработавших правил        
        private void FillRulesTree(WorkingMemory workingMemory, Variable goalVariable, TreeNode parentNode)
        {
            // Пытаемся выяснить значение текущей целевой переменной (его может не быть, если консультация неудачна)
            RuleFact variableValueFact = workingMemory.KnownFacts.Find((fact) => fact.Variable == goalVariable);
            DomainValue goalVariableValue = null;
            if (variableValueFact != null)
                goalVariableValue = variableValueFact.Value;
            // Создаём текущий узел
            TreeNode node;
            // Если текущая целевая переменная не была выведена из какого-либо правила - это листовой узел
            if (!workingMemory.InferenceRulesDict.ContainsKey(goalVariable))
            {
                // Если целевая переменная вообще не означена - так и пишем
                if (goalVariableValue == null)
                    node = new TreeNode($"Цель: {goalVariable} (не была означена)");
                // Иначе - она была запрошена у пользователя
                else
                    node = new TreeNode($"Цель: {goalVariable} = {goalVariableValue} (запрошена у пользователя)");
            }
            // Иначе - создаём текущую вершину с целевой переменной, добавляем к ней лист с её правилом (которое её означило), 
            // и идём по всем переменным посылки этого правила как по локальным целям - это будут другие дочерние вершины
            else
            {
                Rule variableRule = workingMemory.InferenceRulesDict[goalVariable];
                node = new TreeNode($"Цель: {goalVariable} = {goalVariableValue}");
                node.Nodes.Add(variableRule.GetRuleStringView());
                node.Nodes.Add($"Описание: {variableRule.Description}");
                foreach (var fact in variableRule.Premise)
                    FillRulesTree(workingMemory, fact.Variable, node);                
            }
            // Добавляем вершину в дерево. Если у текущей вершины нет родителя, то она - вершина дерева
            if (parentNode == null)
                rulesTreeRoot = node;
            else
                parentNode.Nodes.Add(node);
        }
    }
}
