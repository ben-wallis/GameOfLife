using GameOfLife.UI.ViewModels;

namespace GameOfLife.UI.Views
{
    internal partial class MainWindow : IMainWindow
    {
        public MainWindow(IMainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            DataContext = mainWindowViewModel;
        }
    }
}
