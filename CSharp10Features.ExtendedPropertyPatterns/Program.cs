using CSharp10Features.ExtendedPropertyPatterns;

var rectangleInside = new Rectangle(100, 100);
var rectangle = new Rectangle(200, 300, rectangleInside);

if(rectangle is { rectangle: { Height: > 100} })
{

}

// Can now be defined as a property
if(rectangle is {  rectangle.Height: > 100 } )
{

}
