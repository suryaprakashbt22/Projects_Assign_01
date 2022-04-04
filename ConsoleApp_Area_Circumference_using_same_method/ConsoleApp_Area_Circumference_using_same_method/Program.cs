// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Single Method to Calculate and Print Area and Circumference of a Circle!");
void funAreaCircumference(double radius, out double area, out double circumference)
{
    area = 3.14 * radius * radius;
    circumference = 2 * 3.14 * radius;
}

Console.WriteLine("Enter the Radius of the Circle:");
double radius = Convert.ToDouble(Console.ReadLine());
double area = 0.0, circumference = 0.0;
funAreaCircumference(radius, out area, out circumference);
Console.WriteLine("Area = {0}\nCircumference = {1}", area, circumference);