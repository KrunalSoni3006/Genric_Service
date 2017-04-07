using System;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    

    public class Test : ContextBoundObject
    {
        public void Go()
        {
            int k = 32;
            k *= 2;
        }

        public static string Start()
        {
            Test t = new Test();

            int starttime = Environment.TickCount;
            for (int i = 0; i < 5000000; i++)
                t.Go();
            int endtime = Environment.TickCount;

            return ("Total time is: " + (endtime - starttime).ToString());
        }
    }
}