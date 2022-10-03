using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            
            
            /*List<int> nums = new List<int>();

            while (true)
            {
                nums.Add(i);
                if (s.ElapsedMilliseconds == 5000)
                {
                    break;
                }
                i++;
            }*/

            for (int i = 0; i < 10; i++)
            {
                Test();
            }


            s.Stop();
            Console.WriteLine($"{s.ElapsedMilliseconds} ms taken");
            Console.ReadLine();
        }

        static void Test()
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < 50000000; i++)
            {
                nums.Add(i);
            }
        }
    }
}
