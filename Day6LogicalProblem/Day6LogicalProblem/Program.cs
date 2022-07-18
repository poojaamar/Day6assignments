static Boolean isPresent(int[] arr, int num) //this method checks whether the no is already present in array or not
{
    for (int i = 0; i < arr.Length; i++) // for loop is used so we can compare the value present in num with each value present in array
    {
        if (arr[i] == num)  //if this condition becomes true it means that num is present in array and will return value true
        {
            return true;
        }
    }
    return false;
}
static void generateCouponCode(int totalNum)
{
    int[] couponCode = new int[totalNum];  //creating a array to store the distinct coupon code
    int randomNo = 0, count = 0;
    Boolean check;
    Random random = new Random();
    for (int i = 0; i < couponCode.Length; i++) // for loop is used to generate n no of random number
    {
        randomNo = random.Next(1000, 10000);
        count++;
        check = isPresent(couponCode, randomNo); //the value true or false return from isPresent function is store in check variable
        if (check != true) 
        {
            couponCode[i] = randomNo;
        }
        else
        {
            --i; 
        }
    }
    Console.WriteLine("The unique coupon numbers are :");
    for (int i = 0; i < couponCode.Length; i++) 
    {
        Console.WriteLine(couponCode[i] + " ");
    }
    Console.WriteLine("Total random number needed to have all distinct numbers are : " + count);
}
Console.Write("Enter the number of coupon codes to be generated : ");
int totalNum = int.Parse(Console.ReadLine());  
generateCouponCode(totalNum); 
