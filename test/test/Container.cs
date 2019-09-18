using System;
using System.Collections.Generic;
using System.Text;
using LightInject;

namespace test
{
    public static class Container
    {
        public static IServiceContainer Create()
        {
            var container = new ServiceContainer();
            container.RegisterAssembly(typeof(Container).Assembly, () => new PerContainerLifetime());

            var depency = CreateDepency();
            container.Register(factory => CreateDepency(), new PerContainerLifetime());

            return container;
        }

        private static IDependencyClass CreateDepency()
        {
            return new DependencyClass(12);
        }
    }
}
