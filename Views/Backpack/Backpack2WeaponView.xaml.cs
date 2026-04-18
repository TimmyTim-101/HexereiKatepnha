using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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

    private void InnerListBoxPreviewMouseWheel(object sender, MouseWheelEventArgs e)
    {
        if (sender is not ListBox listBox) return;
        ScrollViewer? scrollViewer = GetVisualChild<ScrollViewer>(listBox);
        if (scrollViewer == null) return;
        bool isAtTop = scrollViewer.VerticalOffset <= 0;
        bool isAtBottom = scrollViewer.VerticalOffset >= scrollViewer.ScrollableHeight;
        bool shouldPassThrough = false;
        if (e.Delta > 0 && isAtTop)
        {
            shouldPassThrough = true;
        }
        else if (e.Delta < 0 && isAtBottom)
        {
            shouldPassThrough = true;
        }

        if (shouldPassThrough)
        {
            e.Handled = true;
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta)
            {
                RoutedEvent = MouseWheelEvent,
                Source = sender
            };
            var parent = VisualTreeHelper.GetParent(listBox) as UIElement;
            parent?.RaiseEvent(eventArg);
        }
    }

    private static T? GetVisualChild<T>(DependencyObject parent) where T : DependencyObject
    {
        for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
        {
            DependencyObject child = VisualTreeHelper.GetChild(parent, i);
            if (child is T t) return t;
            T? childOfChild = GetVisualChild<T>(child);
            if (childOfChild != null) return childOfChild;
        }

        return null;
    }
}