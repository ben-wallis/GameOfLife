using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using GameOfLife.UI.ViewModels;

namespace GameOfLife.UI.WindsorInstallers
{
    public class ViewModelsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IMainWindowViewModel>()
                .ImplementedBy<MainWindowViewModel>()
                .LifeStyle.Transient);

            container.Register(Component
                .For<IGameBoardViewModel>()
                .ImplementedBy<GameBoardViewModel>()
                .LifeStyle.Transient);
        }
    }
}
