using HRSuite.Services.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Unity;

namespace HRSuite.Services
{
    public class ServicesModule : IModule
    {
        private IRegionManager _regionManager;
        private Microsoft.Practices.Unity.IUnityContainer _container;

        public ServicesModule(Microsoft.Practices.Unity.IUnityContainer container, IRegionManager regionManager)
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