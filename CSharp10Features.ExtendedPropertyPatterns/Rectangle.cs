namespace CSharp10Features.ExtendedPropertyPatterns;

internal record Rectangle(int Height, int Width, Rectangle? rectangle = null);
