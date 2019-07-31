using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArr;
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Write text:");
            string text = Console.ReadLine();
            stopwatch.Start();
            Console.WriteLine($"number of words: { text.Split(' ', '\t', ';', '\n').Length}\t");
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"number of sybols: { text.Length}\t" +
                   $"The pased time is: { stopwatch.Elapsed.TotalMilliseconds}");
                break;
            }

            
            Console.ReadLine();
        }
    }
    
}
