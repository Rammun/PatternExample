using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Singlton
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob1 = Singleton1.GetInstance();
            ob1.Data = "Word1";
            Console.WriteLine("ob1 - " + ob1.Data);

            var ob2 = Singleton1.GetInstance();
            Console.WriteLine("ob2 - " + ob2.Data);

            ob1.Data = "Word2";
            Console.WriteLine("ob2 - " + ob2.Data);

            Console.ReadKey();
        }
    }

    public class Singleton1
    {
        private static Singleton1 instance;
        private string data = string.Empty;

        private Singleton1()
        { }

        public static Singleton1 GetInstance()
        {
            if (instance == null)
                instance = new Singleton1();

            return instance;
        }

        public string Data { get; set; }
    }

    public class Singleton2
    {
        static Singleton2 instance = null;
        static readonly object block = new object();

        private string data = string.Empty;

        private Singleton2()
        {
        }

        public static Singleton2 GetInstance()
        {
            lock (block)
            {
                if (instance == null)
                {
                    instance = new Singleton2();
                }
                return instance;
            }
        }

        public string Data { get; set; }
    }
}
