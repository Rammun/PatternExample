using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    public class Summ : Operation
    {
        public Summ()
        {
            Name = "Сумма";
        }

        public override int Do(int x, int y)
        {
            return x + y;
        }
    }
}
