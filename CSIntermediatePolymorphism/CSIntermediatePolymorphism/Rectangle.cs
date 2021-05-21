using System;
using System.Collections.Generic;

namespace CSIntermediatePolymorphism
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("This draws a rectangle.");
        }
    }
}
