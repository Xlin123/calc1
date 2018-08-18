using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        private void Multiply_on(object sender, RoutedEventArgs e)
        {
            string input1 = Number_1.Text;
            string input2 = Number_2.Text;

            Answer.Text = Calculator.Multiply(input1, input2);
            AnswerDescription.Text = input1 + "*" + input2 + "=";


        }
        private void Divide_on(object sender, RoutedEventArgs e)
        {

            string input1 = Number_1.Text;
            string input2 = Number_2.Text;

            Answer.Text = Calculator.Divide(input1, input2);
            AnswerDescription.Text = input1 + "/" + input2 + "=";

        }
        private void Subtract_on(object sender, RoutedEventArgs e)
        {
            string input1 = Number_1.Text;
            string input2 = Number_2.Text;

            Answer.Text = Calculator.Subtract(input1, input2);
            AnswerDescription.Text = input1 + "*" + input2 + "=";

        }
        private void Add_on(object sender, RoutedEventArgs e)
        {
            string input1 = Number_1.Text;
            string input2 = Number_2.Text;

            Answer.Text = Calculator.Add(input1, input2);
            AnswerDescription.Text = input1 + "*" + input2 + "=";

        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

       
    }
}
