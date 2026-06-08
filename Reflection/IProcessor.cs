using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public interface IProcessor<T>
    {
        void Process(T data);
    }
}
