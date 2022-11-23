using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class Program
    {
        static string[] story = System.IO.File.ReadAllLines("Story.txt");
       

        static void Main(string[] args)
        {
            story = new string[9];


            Console.WriteLine("Story:" + story[2]);

            

            Console.ReadKey(true);
        }
    }
}
