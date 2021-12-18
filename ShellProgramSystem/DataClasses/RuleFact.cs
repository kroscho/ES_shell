using System;

namespace ShellProgramSystem.Classes
{
    public class RuleFact : ICloneable
    {                
        public Variable Variable { get; set; }
        public Operation Operation { get; set; }
        public DomainValue Value
        {
            get => value;
            set
            {
                if (!Variable.Domain.IsDomainValueExists(value))
                    throw new ArgumentException("Попытка сравнить значение переменной со значением другого домена.");
                this.value = value;
            }
        }
        private DomainValue value;

        // Конструктор
        public RuleFact(Variable variable, Operation operation, DomainValue value)
        {
            Variable = variable;
            Operation = operation;
            Value = value;
        }

        public RuleFact() { }

        // текстовое представление факта правила
        public override string ToString()
        {
            return $"{Variable.Name} {Operation.ToText()} {Value}";
        }

        // ICloneable
        public object Clone()
        {
            return new RuleFact(Variable, Operation, Value);
        }
    }
}
