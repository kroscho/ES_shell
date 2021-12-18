using System;

namespace ShellProgramSystem.Classes
{
    public class DomainValue : ICloneable
    {
        public string Value { get; set; }

        public DomainValue(string value)
        {
            Value = value;
        }

        public DomainValue() { }

        public override string ToString()
        {
            return Value.ToString();
        }

        public object Clone()
        {
            return new DomainValue(string.Copy(Value));
        }

    }
}
