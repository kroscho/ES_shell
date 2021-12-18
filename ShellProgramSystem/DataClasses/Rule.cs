using System;
using System.Collections.Generic;
using System.Text;

namespace ShellProgramSystem.Classes
{
    public class Rule
    {
        public string Name { get; set; }
        public List<RuleFact> Premise { get; set; }
        public List<RuleFact> Conclusion { get; set; }
        public string Description { get; set; }

        // Конструктор
        public Rule(string name, List<RuleFact> premise, List<RuleFact> conclusion, string description = "")
        {
            Name = name;
            Premise = premise;
            Conclusion = conclusion;
            Description = description;
        }

        public Rule() 
        {
            Premise = new List<RuleFact>();
            Conclusion = new List<RuleFact>();
        }


        // Получить полное строковое представление формата
        // "ЕСЛИ факты_посылки ТО факты_заключения"
        public string GetRuleStringView()
        {
            StringBuilder stringView = new StringBuilder("ЕСЛИ");
            // Формируем посылку
            foreach (var premiseFact in Premise)
                stringView.Append($" {premiseFact} И");
            stringView.Remove(stringView.Length - 2, 2); // удаляем последнее "И" и пробел
            stringView.Append(" ТО");
            // Формируем заключение
            foreach (var conclusionFact in Conclusion)
                stringView.Append($" {conclusionFact} И");
            stringView.Remove(stringView.Length - 2, 2); // удаляем последнее "И" и пробел
            return stringView.ToString();
        }
    }
}
