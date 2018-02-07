using System;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using System.Windows;
using HRSuite.People;
using HRSuite.StatusBar;
using HRSuite.Toolbar;
using HRSuite.Services;
using System.ComponentModel;

namespace HRSuite
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();

        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();

            catalog.AddModule(typeof(ServicesModule));
            catalog.AddModule(typeof(ToolbarModule));
            catalog.AddModule(typeof(PeopleModule));
            catalog.AddModule(typeof(StatusBarModule));

            return catalog;


        }

    }
}
