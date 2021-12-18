using ShellProgramSystem.Classes;
using System.IO;


namespace ShellProgramSystem
{
    class FileManager
    {
        public static void Save(string fileName, KnowledgeBase knowledgeBase)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, append: false))
            {
                outputFile.WriteLine("Domains: [");
                foreach (var domain in knowledgeBase.Domains)
                {
                    outputFile.WriteLine("Domain: {");
                    outputFile.WriteLine("Name: " + domain.Name + ",");
                    outputFile.WriteLine("Values: [");
                    foreach (var value in domain.Values)
                    {
                        outputFile.WriteLine(value + ",");
                    }
                    outputFile.WriteLine("],");
                    outputFile.WriteLine("},");
                }
                outputFile.WriteLine("],");

                outputFile.WriteLine("Variables: [");
                foreach (var variable in knowledgeBase.Variables)
                {
                    outputFile.WriteLine("Variable: {");
                    outputFile.WriteLine("Name: " + variable.Name + ",");
                    outputFile.WriteLine("Type: " + variable.Type.ToString() + ",");
                    outputFile.WriteLine("Domain: " + variable.Domain.Name + ",");
                    outputFile.WriteLine("Question: " + variable.QuestionText + ",");
                    outputFile.WriteLine("},");
                }
                outputFile.WriteLine("],");

                outputFile.WriteLine("Rules: [");
                foreach (var rule in knowledgeBase.Rules)
                {
                    outputFile.WriteLine("Rule: {");
                    outputFile.WriteLine("Name: " + rule.Name + ",");
                    outputFile.WriteLine("Premises: [");
                    foreach (var premise in rule.Premise)
                    {
                        outputFile.WriteLine("Variable: " + premise.Variable.Name + ",");
                        outputFile.WriteLine("Operation: " + premise.Operation + ",");
                        outputFile.WriteLine("Value: " + premise.Value + ",");
                    }
                    outputFile.WriteLine("],");
                    outputFile.WriteLine("Conclusions: [");
                    foreach (var conclusion in rule.Conclusion)
                    {
                        outputFile.WriteLine("Variable: " + conclusion.Variable.Name + ",");
                        outputFile.WriteLine("Operation: " + conclusion.Operation + ",");
                        outputFile.WriteLine("Value: " + conclusion.Value + ",");
                    }
                    outputFile.WriteLine("],");
                    outputFile.WriteLine("Reason: " + rule.Description + ",");
                    outputFile.WriteLine("},");
                }
                outputFile.WriteLine("],");
            }
        }

        public static void Open(string fileName, KnowledgeBase knowledgeBase)
        {         
            using (StreamReader inputFile = new StreamReader(fileName))
            {
                knowledgeBase.Domains.Clear();
                knowledgeBase.Variables.Clear();
                knowledgeBase.Rules.Clear();

                int state = 0;
                string str;
                DomainValue domainValue = null;
                Domain domain = null;
                Variable variable = null;
                Rule rule = null;
                RuleFact ruleFact = null;

                while ((str = inputFile.ReadLine()) != null)
                {
                    #region Domain
                    if (str.Contains("Domains: ["))
                    {
                        state = 1;
                    }
                    if (state == 1 && str.Contains("Domain: {"))
                    {
                        state = 11;
                        domain = new Domain();
                    }
                    if (state == 11 && str.Contains("Name:"))
                    {
                        var s = str.Replace("Name:", "").Trim(new char[] { ' ', ',' });
                        domain.Name = s;
                    }
                    if (state == 11 && str.Contains("Values:"))
                    {
                        state = 12;
                        continue;
                    }
                    if (state == 12 && str.Contains("],"))
                    {
                        state = 11;
                    }
                    if (state == 12)
                    {
                        domainValue = new DomainValue(str.Trim(new char[] { ' ', ',' }));
                        //domainValue.Value = str.Trim(new char[] { ' ', ',' });
                        domain.Values.Add(domainValue);
                    }
                    if (state == 11 && str.Contains("},"))
                    {
                        state = 1;
                        knowledgeBase.Domains.Add(domain);
                    }
                    if (state == 1 && str.Contains("],"))
                    {
                        state = 0;
                    }
                    #endregion

                    #region Variable
                    if (str.Contains("Variables: ["))
                    {
                        state = 2;
                    }
                    if (state == 2 && str.Contains("Variable: {"))
                    {
                        state = 21;
                        variable = new Variable();
                    }
                    if (state == 21 && str.Contains("Name:"))
                    {
                        var s = str.Replace("Name:", "").Trim(new char[] { ' ', ',' });
                        variable.Name = s;
                    }
                    if (state == 21 && str.Contains("Type:"))
                    {
                        var s = str.Replace("Type:", "").Trim(new char[] { ' ', ',' });
                        if (s == "Deduced")
                            variable.Type = VariableType.Deduced;
                        else if (s == "Requested")
                            variable.Type = VariableType.Requested;
                        else
                            variable.Type = VariableType.DeducedRequested;
                    }
                    if (state == 21 && str.Contains("Domain:"))
                    {
                        var s = str.Replace("Domain:", "").Trim(new char[] { ' ', ',' });
                        variable.Domain = knowledgeBase.GetDomain(s);
                    }
                    if (state == 21 && str.Contains("Question:"))
                    {
                        var s = str.Replace("Question:", "").Trim(new char[] { ' ', ',' });
                        variable.QuestionText = s;
                    }
                    if (state == 21 && str.Contains("},"))
                    {
                        state = 2;
                        knowledgeBase.Variables.Add(variable);
                    }
                    if (state == 2 && str.Contains("],"))
                    {
                        state = 0;
                    }
                    #endregion

                    #region Rule
                    if (str.Contains("Rules: ["))
                    {
                        state = 3;
                    }
                    if (state == 3 && str.Contains("Rule: {"))
                    {
                        state = 31;
                        rule = new Rule();
                    }
                    else if (state == 31 && str.Contains("Name:"))
                    {
                        var s = str.Replace("Name:", "").Trim(new char[] { ' ', ',' });
                        rule.Name = s;
                    }
                    if (state == 31 && str.Contains("Premises: ["))
                    {
                        state = 32;
                    }
                    if (state == 32 && str.Contains("Variable:"))
                    {
                        var s = str.Replace("Variable: ", "").Trim(new char[] { ' ', ',' });
                        var vr = knowledgeBase.GetVariable(s);

                        if (vr != null)
                        {
                            ruleFact = new RuleFact();
                            ruleFact.Variable = vr;
                        }
                    }
                    if (state == 32 && str.Contains("Operation:"))
                    {
                        var s = str.Replace("Operation: ", "").Trim(new char[] { ' ', ',' });                                               
                        ruleFact.Operation = OperationExtensions.FromText(s);
                    }
                    if (state == 32 && str.Contains("Value:"))
                    {                        
                        var s = str.Replace("Value: ", "").Trim(new char[] { ' ', ',' });
                        domainValue = knowledgeBase.GetDomainValue(s, ruleFact.Variable);                        
                        ruleFact.Value = domainValue;
                        rule.Premise.Add(ruleFact);
                    }
                    if (state == 32 && str.Contains("],"))
                    {
                        state = 31;
                    }
                    if (state == 31 && str.Contains("Conclusions: ["))
                    {
                        state = 33;
                    }
                    if (state == 33 && str.Contains("Variable:"))
                    {
                        var s = str.Replace("Variable: ", "").Trim(new char[] { ' ', ',' });
                        var vr = knowledgeBase.GetVariable(s);

                        if (vr != null)
                        {
                            ruleFact = new RuleFact();
                            ruleFact.Variable = vr;
                        }
                    }
                    if (state == 33 && str.Contains("Operation:"))
                    {
                        var s = str.Replace("Operation: ", "").Trim(new char[] { ' ', ',' });
                        ruleFact.Operation = OperationExtensions.FromText(s);
                    }
                    if (state == 33 && str.Contains("Value:"))
                    {
                        var s = str.Replace("Value: ", "").Trim(new char[] { ' ', ',' });
                        domainValue = knowledgeBase.GetDomainValue(s, ruleFact.Variable);
                        ruleFact.Value = domainValue;
                        rule.Conclusion.Add(ruleFact);   
                    }
                    if (state == 33 && str.Contains("],"))
                    {
                        state = 31;
                    }
                    if (state == 31 && str.Contains("Reason:"))
                    {
                        var s = str.Replace("Reason:", "").Trim(new char[] { ' ', ',' });
                        rule.Description = s;
                    }
                    if (state == 31 && str.Contains("},"))
                    {
                        state = 3;
                        knowledgeBase.Rules.Add(rule);
                    }
                    if (state == 3 && str.Contains("],"))
                    {
                        state = 0;
                    }
                    #endregion
                }
            }
        }
    }
}
