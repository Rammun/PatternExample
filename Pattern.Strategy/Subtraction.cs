using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    public class Subtraction : Operation
    {
        public Subtraction()
        {
            Name = "Разность";
        }

        public override int Do(int x, int y)
        {
            return x - y;
        }
    }
}
