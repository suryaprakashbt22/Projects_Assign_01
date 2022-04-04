// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sum of Array Elements using Static Method");
static int arraySum(params int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum+=arr[i];
    }
    return sum;
}
//static void Main(string[] args)
Console.WriteLine("Enter the Size of Array:");
int N=Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];
Console.WriteLine("Enter the Array Elements!");
for(int i = 0; i < N; i++)
{
    Console.WriteLine("Enter element No. {0}", i+1);
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The Sum is {0}",arraySum(5,5,6,2));
//Console.WriteLine(arraySum(a));
