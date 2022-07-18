Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()); 
int originalNum = num; 
int palin = 0, ans;
while (num > 0) 
{
    ans = num % 10;
    palin = palin * 10 + ans; 
    num /= 10; 
}
if (originalNum == palin) 
{
    Console.WriteLine("Number is Palindrome");
}
else
{
    Console.WriteLine("Number is not Palindrome");
}

