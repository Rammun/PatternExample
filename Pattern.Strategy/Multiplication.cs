using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    public class Multiplication : Operation
    {
        public Multiplication()
        {
            Name = "Умножение";
        }

        public override int Do(int x, int y)
        {
            return x * y;
        }
    }
}
