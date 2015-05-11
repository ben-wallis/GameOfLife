using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using GameOfLife.UI.Views;

namespace GameOfLife.UI.WindsorInstallers
{
    public class ViewsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                        .For<IMainWindow>()
                        .ImplementedBy<MainWindow>()
                        .LifeStyle.Singleton);
        }
    }
}
