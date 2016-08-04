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
            Operation operation;

            operation = new Summ();
            Method(operation);

            operation = new Subtraction();
            Method(operation);

            operation = new Division();
            Method(operation);

            operation = new Multiplication();
            Method(operation);

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
