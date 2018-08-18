using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Calculator
    {
        public static string Multiply(string input1, string input2)
        {

            string answerText = "--";

            if (decimal.TryParse(input1, out decimal a) && decimal.TryParse(input2, out decimal b))
                answerText = (a * b).ToString();

            return answerText;
        }

        public static string Divide(string input1, string input2)
        {
            string answerText = "--";

            if (decimal.TryParse(input1, out decimal a) && decimal.TryParse(input2, out decimal b) && b != 0)
                answerText = (a / b).ToString();

            return answerText;
        }

        public static string Subtract(string input1, string input2)
        {
            string answerText = "--";

            if (decimal.TryParse(input1, out decimal a) && decimal.TryParse(input2, out decimal b))
                answerText = (a - b).ToString();

            return answerText;
        }

        public static string Add(string input1, string input2)
        {
            string answerText = "--";

            if (decimal.TryParse(input1, out decimal a) && decimal.TryParse(input2, out decimal b))
                answerText = (a + b).ToString();

            return answerText;
        }
    }
}
