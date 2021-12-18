using System.Collections.Generic;
using System.Text;

namespace ShellProgramSystem.Classes
{
    public class KnowledgeBase
    {
        // Словесное описание базы знаний
        public string Description { get; set; }
        
        public List<Rule> Rules { get; set; }
        public List<Variable> Variables { get; set; }
        public List<Domain> Domains { get; set; }

        // Конструкторы
        public KnowledgeBase()
        {
            Description = "";
            Rules = new List<Rule>();
            Variables = new List<Variable>();
            Domains = new List<Domain>();
        }

        public KnowledgeBase(List<Rule> rules, List<Variable> variables, List<Domain> domains, string description)
        {
            Description = description;
            Rules = rules;
            Variables = variables;
            Domains = domains;
        }

        // ----Работа с элементами базы знаний
        public Rule GetRule(string name)
        {
            return Rules.Find((r) => r.Name == name);
        }

        public Variable GetVariable(string name)
        {
            return Variables.Find((v) => v.Name == name);
        }

        public Domain GetDomain(string name)
        {
            return Domains.Find((d) => d.Name == name);
        }

        public DomainValue GetDomainValue(string name, Variable variable)
        {
            var domain = variable.Domain;
            var domainValue = domain.Values.Find((dv) => dv.Value == name);
            if (domainValue != null)
            {
                return domainValue;
            }
            return null;
            //foreach (var domain in Domains)
            //{
            //    var domainValue = domain.Values.Find((dv) => dv.Value == name);
            //    if (domainValue != null)
            //    {
            //        return domainValue;
            //    }
            //}
            //return null;
        }


        // Получить список правил, использующих заданную переменную
        public List<Rule> GetRulesUsingVariable(Variable variable)
        {
            List<Rule> rez = new List<Rule>();
            foreach (var rule in Rules)
            {
                bool isUse = false;
                foreach (var ruleFact in rule.Premise)
                    if (ruleFact.Variable == variable)
                        isUse = true;
                foreach (var ruleFact in rule.Conclusion)
                    if (ruleFact.Variable == variable)
                        isUse = true;
                if (isUse)
                    rez.Add(rule);
            }
            return rez.Count != 0 ? rez : null;
        }

        // Получить список правил, использующих заданный домен
        public List<Rule> GetRulesUsingDomain(Domain domain)
        {
            List<Rule> rez = new List<Rule>();
            foreach (var rule in Rules)
            {
                bool isUse = false;
                foreach (var ruleFact in rule.Premise)
                    if (ruleFact.Variable.Domain == domain)
                        isUse = true;
                foreach (var ruleFact in rule.Conclusion)
                    if (ruleFact.Variable.Domain == domain)
                        isUse = true;
                if (isUse)
                    rez.Add(rule);
            }
            return rez.Count != 0 ? rez : null;
        }

        // Получить список правил, использующих заданное значение из домена
        public List<Rule> GetRulesUsingDomainValue(DomainValue domainValue)
        {
            List<Rule> rez = new List<Rule>();
            foreach (var rule in Rules)
            {
                bool isUse = false;
                foreach (var ruleFact in rule.Premise)
                    if (ruleFact.Value == domainValue)
                        isUse = true;
                foreach (var ruleFact in rule.Conclusion)
                    if (ruleFact.Value == domainValue)
                        isUse = true;
                if (isUse)
                    rez.Add(rule);
            }
            return rez.Count != 0 ? rez : null;
        }

        // Получить список переменных, использующий заданный домен.
        public List<Variable> GetVariablesUsingDomain(Domain domain)
        {
            List<Variable> rez = new List<Variable>();
            foreach (var variable in Variables)
                if (variable.Domain == domain)
                    rez.Add(variable);
            return rez.Count != 0 ? rez : null;
        }

        // Генерация имён для новых объектов базы знаний
  
        // Получить следующее возможное уникальное имя для правила
        public string GetNextRuleName()
        {
            int ruleNumber = Rules.Count + 1;
            string name = $"r{ruleNumber}";
            while (GetRule(name) != null)
            {
                ruleNumber++;
                name = $"r{ruleNumber}";
            }
            return name;
        }

        // Получить следующее возможное уникальное имя для переменной
        public string GetNextVariableName()
        {
            int variableNumber = Variables.Count + 1;
            string name = $"v{variableNumber}";
            while (GetVariable(name) != null)
            {
                variableNumber++;
                name = $"v{variableNumber}";
            }
            return name;
        }

        // Получить следующее возможное уникальное имя для домена
        public string GetNextDomainName()
        {
            int domainNumber = Domains.Count + 1;
            string name = $"d{domainNumber}";
            while (GetDomain(name) != null)
            {
                domainNumber++;
                name = $"d{domainNumber}";
            }
            return name;
        }

        // ----Статические методы

        /// Сформировать имена переменных variables в список через запятую
        public static string GetVariablesNamesString(List<Variable> variables)
        {
            StringBuilder variablesNames = new StringBuilder();
            foreach (var variable in variables)
            {
                variablesNames.Append($"\"{variable.Name}\", ");
            }
            variablesNames.Remove(variablesNames.Length - 2, 2);
            return variablesNames.ToString();
        }

        /// Сформировать имена правил rules в список через запятую
        public static string GetRulesNamesString(List<Rule> rules)
        {
            StringBuilder rulesNames = new StringBuilder();
            foreach (var rule in rules)
            {
                rulesNames.Append($"\"{rule.Name}\", ");
            }
            rulesNames.Remove(rulesNames.Length - 2, 2);
            return rulesNames.ToString();
        }
    }
}
