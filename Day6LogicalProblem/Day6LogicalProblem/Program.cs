int num1 = 0, num2 = 1, num3;
Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()); 
Console.WriteLine(num1);
for (int i = 2; i <= num; i++)  
{
    num3 = num1 + num2; 
    Console.WriteLine(num3);
    num1 = num2;
    num2 = num3;
}