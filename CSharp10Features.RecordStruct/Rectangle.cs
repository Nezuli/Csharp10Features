namespace CSharp10Features.RecordStruct;

internal class Rectangle
{
    public Rectangle(int height, int width)
    {
        Height = height;
        Width = width;
    }
    public int Height { get; init; }
    public int Width { get; init; }
}
