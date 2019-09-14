using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public interface IDependencyClass
    {
        int GetSomeName();
    }

    public class DependencyClass : IDependencyClass
    {
        public int GetSomeName()
        {
            throw new NotImplementedException();
        }
    }
}
