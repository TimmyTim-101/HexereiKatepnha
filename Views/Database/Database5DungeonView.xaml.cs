namespace HexereiKatepnha.Views.Database;

public partial class Database5DungeonView
{
    public Database5DungeonView()
    {
        InitializeComponent();
    }

    private void InnerScrollViewerPreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
    {
        var scv = (System.Windows.Controls.ScrollViewer)sender;
        bool isAtTop = scv.VerticalOffset <= 0 && e.Delta > 0;
        bool isAtBottom = scv.VerticalOffset >= scv.ScrollableHeight && e.Delta < 0;
        if (isAtTop || isAtBottom)
        {
            e.Handled = true;
            var eventArg = new System.Windows.Input.MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta)
            {
                RoutedEvent = MouseWheelEvent,
                Source = sender
            };
            var parent = System.Windows.Media.VisualTreeHelper.GetParent(scv) as System.Windows.UIElement;
            parent?.RaiseEvent(eventArg);
        }
    }
}