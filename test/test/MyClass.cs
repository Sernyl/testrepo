using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public interface IMyClass
    {
        void Work();
    }

    public class MyClass : IMyClass
    {
        public void Work()
        {
            var dep = new DependencyClass();
            Console.WriteLine(dep.GetSomeName());
        }
    }
}
