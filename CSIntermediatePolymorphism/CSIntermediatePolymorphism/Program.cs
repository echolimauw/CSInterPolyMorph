using System;
using System.IO;
using System.Collections.Generic;

namespace CSIntermediatePolymorphism
{
    partial class Program
    {
        static void Main(string[] args)
        {
            

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
