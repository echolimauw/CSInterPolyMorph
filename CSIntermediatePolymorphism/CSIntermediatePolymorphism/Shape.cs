using System;

namespace CSIntermediatePolymorphism
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }


        public abstract void Draw();

        public void Copy()

        {
            Console.WriteLine("Shape copied to clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Shape selected.");
        }
    }
}
