using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory figureFactory;

            figureFactory = new CircleFactory();
            var circle = figureFactory.Create();
            circle.Draw();

            Console.ReadKey();

            figureFactory = new TriangleFactory();
            var triangle = figureFactory.Create();
            triangle.Draw();

            Console.ReadKey();
        }
    }

    abstract class Figure
    {
        public abstract void Draw();
    }

    class Circle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Нарисовали круг"); ;
        }
    }

    class Triangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Нарисовали треугольник");
        }
    }

    abstract class Factory
    {
        public abstract Figure Create();
    }

    class CircleFactory : Factory
    {
        public override Figure Create()
        {
            return new Circle();
        }
    }

    class TriangleFactory : Factory
    {
        public override Figure Create()
        {
            return new Triangle();
        }
    }
}
