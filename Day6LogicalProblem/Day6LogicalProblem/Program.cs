Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()); 
int total = 0;
for (int i = 1; i < num; i++)
{
    if (num % i == 0) 
    {
        total += i; 
    }
}
if (num == total) 
{
    Console.WriteLine("Entered number is a Perfect number.");
}
else
{
    Console.WriteLine("Entered number is not a Perfect number.");
}