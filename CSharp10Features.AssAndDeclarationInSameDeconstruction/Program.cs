using CSharp10Features.AssAndDeclarationInSameDeconstruction;

var rectangle = new Rectangle(200, 400);

(int h, int w) = rectangle;

int height = 0;
//int width = 0;
// Able to mix pre-declared variables into deconstruction
(height, int width) = rectangle;