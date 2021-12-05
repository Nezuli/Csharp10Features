namespace CSharp10Features.StructureTypesImprovements
{
    internal struct Rectangle
    {
        public int Height { get; init; }
        public int Width { get; init; }

        // Not valid in V9 - but valid in V10
        public Rectangle() 
        {
            Height = 0;
            Width = 0;
        }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}