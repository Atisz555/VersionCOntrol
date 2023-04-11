using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact_pattern2.Abstraction
{
    public interface IToyFactory
    {
        Toy CreateNew();

    }
}
