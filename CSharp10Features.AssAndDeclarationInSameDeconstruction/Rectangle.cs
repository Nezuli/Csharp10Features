namespace CSharp10Features.AssAndDeclarationInSameDeconstruction;

internal class Rectangle
{
    public int Height { get; init; }
    public int Width { get; init; }
    public Rectangle(int height, int width)
    {
        Height = height;
        Width = width;
    }

    internal void Deconstruct(out int height, out int width)
    {
        height = Height;
        width = Width;
    }
}
