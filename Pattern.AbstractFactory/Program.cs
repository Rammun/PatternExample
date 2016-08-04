using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SpriteFactory spriteFactory;
            Sprite sprite;

            spriteFactory = new Sprite2DFactory();
            sprite = new Sprite(spriteFactory);
            sprite.Draw();

            Console.ReadKey();

            spriteFactory = new Sprite3DFactory();
            sprite = new Sprite(spriteFactory);
            sprite.Draw();

            Console.ReadKey();
        }
    }

    abstract class SpriteFactory
    {
        public abstract LeftPicture CreateLeft();
        public abstract RightPicture CreateRight();
    }

    class Sprite2DFactory : SpriteFactory
    {
        public override LeftPicture CreateLeft()
        {
            return new Left2D();
        }

        public override RightPicture CreateRight()
        {
            return new Right2D();
        }
    }

    class Sprite3DFactory : SpriteFactory
    {
        public override LeftPicture CreateLeft()
        {
            return new Left3D();
        }

        public override RightPicture CreateRight()
        {
            return new Right3D();
        }
    }

    abstract class LeftPicture
    {
        public abstract void Draw();
    }

    abstract class RightPicture
    {
        public abstract void Draw();
    }

    class Left2D : LeftPicture
    {
        public override void Draw()
        {
            Console.WriteLine("Нарисовал левую 2D картинку");
        }
    }

    class Right2D : RightPicture
    {
        public override void Draw()
        {
            Console.WriteLine("Нарисовал правую 2D картинку");
        }
    }

    class Left3D : LeftPicture
    {
        public override void Draw()
        {
            Console.WriteLine("Нарисовал левую 3D картинку");
        }
    }

    class Right3D : RightPicture
    {
        public override void Draw()
        {
            Console.WriteLine("Нарисовал правую 3D картинку");
        }
    }

    class Sprite
    {
        private LeftPicture leftPicture;
        private RightPicture rightPicture;

        public Sprite(SpriteFactory factory)
        {
            rightPicture = factory.CreateRight();
            leftPicture = factory.CreateLeft();
        }

        public void Draw()
        {
            leftPicture.Draw();
            rightPicture.Draw();
        }
    }
}
