namespace CSIntermediatePolymorphism
{
    public class Circle : Shape
    {
        public override void Draw()
        {

        }
    }

    public class Rectangle : Shape
    {

    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}
