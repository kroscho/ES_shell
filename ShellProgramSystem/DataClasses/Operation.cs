
namespace ShellProgramSystem.Classes
{
    public enum Operation
    {
        Equal,  //равно
        NotEqual,  // не равно
        Greater,   // больше    
        GreaterEqual,  // больше или равно     
        Lower,   // меньше
        LowerEqual   // меньше или равно
    }
    public static class OperationExtensions
    {
        // Метод расширения ToOperationString для enum Operation,
        // возвращающий строковое представление данной операции
       
        public static string ToText(this Operation operation)
        {
            switch (operation)
            {
                case Operation.Equal:
                    return "=";
                case Operation.NotEqual:
                    return "<>";
                case Operation.Greater:
                    return ">";
                case Operation.GreaterEqual:
                    return ">=";
                case Operation.Lower:
                    return "<";
                case Operation.LowerEqual:
                    return "<=";
                default:
                    return "UNKNOWN_OP";
            }
        }
       
        // Метод, возвращающий операцию по её строковому представлению
        
        public static Operation FromText(string operationString)
        {
            // Если вдруг подходящей операции не нашли, вернём равенство
            switch (operationString)
            {
                case "=":
                    return Operation.Equal;
                case "<>":
                    return Operation.NotEqual;
                case ">":
                    return Operation.Greater;
                case ">=":
                    return Operation.GreaterEqual;
                case "<":
                    return Operation.Lower;
                case "<=":
                    return Operation.LowerEqual;
                default:
                    return Operation.Equal;
            }
        }
    }
}
