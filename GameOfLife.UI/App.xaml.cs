﻿using System.Windows;

using Castle.Windsor;
using Castle.Windsor.Installer;

using GameOfLife.UI.Views;

namespace GameOfLife.UI
{
    public partial class App
    {
        private IWindsorContainer _container;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _container = new WindsorContainer();
            _container.Install(
                FromAssembly.This()
                //FromAssembly.Named("GameOfLife.Core")
            );

            var mainWindow = _container.Resolve<IMainWindow>();
            mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _container.Dispose();
            base.OnExit(e);
        }
    }
}
