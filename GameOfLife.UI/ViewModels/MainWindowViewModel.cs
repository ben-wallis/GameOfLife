namespace GameOfLife.UI.ViewModels
{
    internal class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IGameBoardViewModel _gameBoardViewModel;

        public MainWindowViewModel(IGameBoardViewModel gameBoardViewModel)
        {
            _gameBoardViewModel = gameBoardViewModel;
        }

        public IGameBoardViewModel GameBoardViewModel
        {
            get
            {
                return _gameBoardViewModel;
            }
        }
    }
}
