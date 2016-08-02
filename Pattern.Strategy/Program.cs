using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = new Summ();
            var sub = new Subtraction();
            var div = new Division();
            var mul = new Multiplication();

            Method(sum);
            Method(sub);
            Method(div);
            Method(mul);

            Console.ReadKey();
        }

        static void Method (Operation op)
        {
            var name = op.Name;
            var result = op.Do(2, 3);
            Console.WriteLine("Результат: {0} {1}", name, result);            
        }
    }
}
