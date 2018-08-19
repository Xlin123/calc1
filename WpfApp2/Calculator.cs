namespace WpfApp2
{
    public class Calculator
    {
        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide,
        }

        public static string Multiply(string input1, string input2)
        {
            return Calculate(input1, input2, Operation.Multiply);
        }

        public static string Divide(string input1, string input2)
        {
            return Calculate(input1, input2, Operation.Divide);
        }

        public static string Subtract(string input1, string input2)
        {
            return Calculate(input1, input2, Operation.Subtract);
        }

        public static string Add(string input1, string input2)
        {
            return Calculate(input1, input2, Operation.Add);
        }

        private static string Calculate(string input1, string input2, Operation operation)
        {
            string answerText = "--";

            if (divisorIsZero(input2, operation))
                return answerText;

            if (decimal.TryParse(input1, out decimal a) && decimal.TryParse(input2, out decimal b))
            {
                switch (operation)
                {
                    case Operation.Add:
                        answerText = (a + b).ToString();
                        break;
                    case Operation.Subtract:
                        answerText = (a - b).ToString();
                        break;
                    case Operation.Divide:
                        answerText = (a / b).ToString();
                        break;
                    case Operation.Multiply:
                        answerText = (a * b).ToString();
                        break;
                    default:
                        break;
                }
            }
            return answerText;
        }

        private static bool divisorIsZero(string divisor, Operation operation)
        {
            return (decimal.TryParse(divisor, out decimal b) && operation == Operation.Divide && b == 0);
        }
    }
}
