using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    public abstract class Operation
    {
        public string Name { get; set; }
        public abstract int Do(int x, int y);
    }
}
