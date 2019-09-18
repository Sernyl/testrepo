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
        public DependencyClass(int value)
        {
            Value = value;
        }

        public int GetSomeName()
        {
            var r = new Random();
            return r.Next(5);
        }

        public int Value { get; }
    }
}
