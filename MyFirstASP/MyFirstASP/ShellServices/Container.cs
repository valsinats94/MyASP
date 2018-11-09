using MyFirstAsp.Core.Interfaces.Services;
using SimpleInjector;
using SimpleInjector.Advanced;
using System;
using System.Collections;

namespace MyFirstASP.ShellServices
{
    public class InjectionContainer : Container, IInjectionContainer
    {
        public InjectionContainer()
        {
            IShellService shellService = new ShellService();
            shellService.ConfigureDependancyInjection();
        }

        public new void RegisterCollection(Type serviceType, IEnumerable containerUncontrolledCollection)
        {
            base.RegisterCollection(serviceType, containerUncontrolledCollection);
        }

        public new void RegisterInitializer(Action<InstanceInitializationData> instanceInitializer, Predicate<InitializerContext> predicate)
        {
            base.RegisterInitializer(instanceInitializer, predicate);
        }

        void IInjectionContainer.Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
