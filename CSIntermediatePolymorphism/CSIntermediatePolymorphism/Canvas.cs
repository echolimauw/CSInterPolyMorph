using System.Collections.Generic;

namespace CSIntermediatePolymorphism
{
    public class Canvas
    {
        public void Drawshapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
