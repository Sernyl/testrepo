using System;
using LightInject;

namespace test
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var container = Container.Create();

            var depClass = container.GetInstance<IDependencyClass>();
            var dep2 = container.GetInstance<IDependencyClass>();

        }
    }
}
