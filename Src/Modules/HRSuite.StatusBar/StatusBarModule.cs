using HRSuite.StatusBar.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Unity;

namespace HRSuite.StatusBar
{
    public class StatusBarModule : IModule
    {
        private IRegionManager _regionManager;
        private Unity.IUnityContainer _container;

        public StatusBarModule(Unity.IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<ViewA>();
        }
    }
}