using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace HexereiKatepnha.Views.Backpack;

using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

public partial class Backpack2WeaponView
{
    public Backpack2WeaponView()
    {
        InitializeComponent();
        Loaded += Backpack2WeaponView_Loaded;
    }

    private void Backpack2WeaponView_Loaded(object sender, RoutedEventArgs e)
    {
        Loaded -= Backpack2WeaponView_Loaded;
        AddWeaponPopup.Placement = PlacementMode.AbsolutePoint;
        AddWeaponPopup.HorizontalOffset = -9999;
        AddWeaponPopup.VerticalOffset = -9999;
        AddWeaponPopup.IsOpen = true;
        Dispatcher.BeginInvoke(new Action(() =>
        {
            AddWeaponPopup.IsOpen = false;
            AddWeaponPopup.ClearValue(Popup.PlacementProperty);
            AddWeaponPopup.ClearValue(Popup.HorizontalOffsetProperty);
            AddWeaponPopup.ClearValue(Popup.VerticalOffsetProperty);
        }), DispatcherPriority.Loaded);
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
            else if (textBox.Text.Length > 1 && textBox.Text.StartsWith('0'))
            {
                textBox.Text = textBox.Text.TrimStart('0');
                textBox.CaretIndex = textBox.Text.Length;
            }
        }
    }
}