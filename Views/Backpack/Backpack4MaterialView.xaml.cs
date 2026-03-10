using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace HexereiKatepnha.Views.Backpack;

public partial class Backpack4MaterialView
{
    public Backpack4MaterialView()
    {
        InitializeComponent();
    }

    private void NumberOnlyTextBox(object sender, TextCompositionEventArgs e)
    {
        Regex regex = new Regex("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
    }

    private void NumberTextChanged(object sender, TextChangedEventArgs e)
    {
        if (sender is TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "0";
                textBox.SelectAll();
            }
            else if (textBox.Text.Length > 1 && textBox.Text.StartsWith("0"))
            {
                textBox.Text = textBox.Text.TrimStart('0');
                textBox.CaretIndex = textBox.Text.Length;
            }
        }
    }
}