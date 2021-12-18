namespace ShellProgramSystem.Classes
{
    // перечисление для типа переменной
    public enum VariableType
    {
        Requested, // Запрашиваемая
        Deduced, // Выводимая
        DeducedRequested,  // Выводимо-запрашиваемая
    }
    public static class VariableTypeExtensions
    {
        // Метод расширения ToText для enum Operation,
        // возвращающий текстовое представление типа переменной
        public static string ToText(this VariableType variableType)
        {
            switch (variableType)
            {
                case VariableType.Requested:
                    return "Запрашиваемая";
                case VariableType.Deduced:
                    return "Выводимая";
                case VariableType.DeducedRequested:
                    return "Выводимо-запрашиваемая";
                default:
                    return "UNKNOWN_TYPE";
            }
        }
    }
}
