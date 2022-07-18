using System;
using System.Diagnostics;

Stopwatch timer = new Stopwatch(); 
static Boolean startStopwatch(Stopwatch timer)  
{
    Console.WriteLine("Enter 1 to start the stopwatch:");
    int startOption = int.Parse(Console.ReadLine()); 
    if (startOption == 1) 
    {
        timer.Start();
        return true;
    }
    else
    {
        return false;
    }

}
static Boolean stopStopwatch(Stopwatch timer) 
{
    Console.WriteLine("Enter 2 to stop the stopwatch:");
    int startOption = int.Parse(Console.ReadLine());
    if (startOption == 2) 
    {
        timer.Stop();
        return true;
    }
    else
    {
        return false;
    }

}
static void elapsedTime(Stopwatch timer) 
{
    Boolean start = startStopwatch(timer); 
    if (start) 
    {
        Console.WriteLine("Timer started");
        Boolean stop = stopStopwatch(timer);
        if (stop)
        {
            Console.WriteLine("Timer stopped");
            Console.WriteLine("The Elapsed time is " + timer.Elapsed); 
        }
        else 
        {
            Console.WriteLine("Wrong input... Timer didn't stop");
        }
    }
    else
    {
        Console.WriteLine("Wrong input... Timer didn't start");
    }


}
elapsedTime(timer); 

