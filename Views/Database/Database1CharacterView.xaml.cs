using System.Windows.Controls;

namespace HexereiKatepnha.Views.Database;

public partial class Database1CharacterView
{
    public Database1CharacterView()
    {
        InitializeComponent();
    }

    private void ScrollViewer_OnScrollChanged(object sender, ScrollChangedEventArgs e)
    {
        if (sender is ScrollViewer scrollViewer)
        {
            if (e.VerticalChange > 0)
            {
                if (scrollViewer.VerticalOffset + scrollViewer.ViewportHeight >= scrollViewer.ExtentHeight - 50)
                {
                    if (this.DataContext is HexereiKatepnha.ViewModels.Database.Database1CharacterViewModel viewModel)
                    {
                        viewModel.LoadMoreCharacters();
                    }
                }
            }
        }
    }
}