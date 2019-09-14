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
            try
            {
                Console.WriteLine(dep.GetSomeName() + 12);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            
        }
    }
}
