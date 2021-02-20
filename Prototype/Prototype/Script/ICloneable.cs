using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Script
{
    public interface ICloneable
    {
        T Clone<T>();
    }
}
