using System;
using System.Collections.Generic;

namespace ShellProgramSystem.Classes
{
    public class Domain
    {
        public string Name { get; set; }
        public List<DomainValue> Values { get; set; }

        public Domain(string name, List<string> values)
        {
            Name = name;
            Values = new List<DomainValue>(values.Count);
            foreach (var value in values)
                Values.Add(new DomainValue(value));
        }
        public Domain(string name, List<DomainValue> values)
        {
            Name = name;
            Values = values;
        }

        public Domain() 
        {
            Values = new List<DomainValue>();
        }

        // проверка на присутствие значения домена в спике значений 
        public bool IsDomainValueExists(DomainValue domainValue)
        {
            int index = Values.FindIndex((v) => v == domainValue);
            return index != -1;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
