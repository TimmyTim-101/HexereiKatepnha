using HexereiKatepnha.ViewModels;

namespace HexereiKatepnha
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel(1);
        }
    }
}