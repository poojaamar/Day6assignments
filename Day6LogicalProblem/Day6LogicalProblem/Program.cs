Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()); 
int ans, count = 0;
for (int i = 2; i <= num / 2; i++)
{
    ans = num % i; 
    if (ans == 0) 
    {
        count++;
    }
}
if (count == 0) 
{
    Console.WriteLine(num + " is a Prime Number");
}
else
{
    Console.WriteLine(num + " is not a Prime Number");
}