using System;
using System.

public class Test : ContextBoundObject
{
    public void Go()
    {
        int k = 32;
        k *= 2;
    }

     static void Main()
    {
        Test t = new Test();

        int starttime = Environment.TickCount;
        for (int i = 0; i < 5000000; i++)
            t.Go();
        int endtime = Environment.TickCount;

       Console.WriteLine("Total time is: " + (endtime - starttime).ToString());
    }
}