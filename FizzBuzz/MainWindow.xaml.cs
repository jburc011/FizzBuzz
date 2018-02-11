using System.Windows;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            outputRichTextBox.Document.Blocks.Clear();
            int.TryParse(startTextBox.Text, out int start);
            int.TryParse(endTextBox.Text, out int end);
            int.TryParse(fizzModTextBox.Text, out int fizzMod);
            int.TryParse(buzzModTextBox.Text, out int buzzMod);
            string fizz = fizzPrintTextBox.Text;
            string buzz = buzzPrintTextBox.Text;
            string output;

            for (int i = start; i <= end; i++)
            {
                if(i % fizzMod == 0 && i % buzzMod == 0)
                {
                    output = fizz + buzz;
                }
                else if(i % fizzMod == 0)
                {
                    output = fizz;
                }
                else if(i % buzzMod == 0)
                {
                    output = buzz;
                }
                else
                {
                    output = i.ToString();
                }
                outputRichTextBox.AppendText(output + "\r");
            }
        }

        private void AllowInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            // Only allow digit input
            e.Handled = !Regex.IsMatch(e.Text, "\\d.*");
        }
    }
}
