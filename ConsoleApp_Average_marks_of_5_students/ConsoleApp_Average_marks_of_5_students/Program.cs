// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] student_marks = new int[5];
Console.WriteLine("Enter the respective marks of students:");
int sum = 0;
for(int i=0;i< student_marks.Length; i++)
{
    Console.WriteLine("Enter the marks obtained by Student No. {0}",i+1);
    student_marks[i]=Convert.ToInt32(Console.ReadLine());
    sum+=student_marks[i];
}
Console.WriteLine("The Average Marks Obtained is {0}", (double)sum / 5);
