using System;

namespace CSIntermediatePolymorphism
{
    partial class Program
    {
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("This draws a circle.");
            }
        }
    }
}
