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
}