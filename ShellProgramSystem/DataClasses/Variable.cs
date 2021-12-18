using System;

namespace ShellProgramSystem.Classes
{
    // класс переменной из БЗ
    public class Variable
    {
        public string Name { get; set; }
        public Domain Domain { get; set; }
        public VariableType Type { get; set; }
        public string QuestionText { get; set; }

        public Variable(string name, Domain domain, VariableType type, string questionText = "")
        {
            Name = name;
            Domain = domain;
            Type = type;
            QuestionText = questionText;
        }

        public Variable() { }

        public override string ToString()
        {
            return Name;
        }        
    }
}
