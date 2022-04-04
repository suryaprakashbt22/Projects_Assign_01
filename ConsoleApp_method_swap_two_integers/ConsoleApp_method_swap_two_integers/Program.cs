// See https://aka.ms/new-console-template for more information
Console.WriteLine("Method to swap two integers!");

void swap(ref int a, ref int b)
{
    int c;
    c = a;
    a = b;
    b = c;
}

Console.WriteLine("Enter the first integer:");
int firstNo=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second integer:");
int secondNo = Convert.ToInt32(Console.ReadLine());

swap(ref firstNo, ref secondNo);
Console.WriteLine("After swapping:");
Console.WriteLine("First Number is = {0} AND Second Number is = {1}", firstNo,secondNo);





