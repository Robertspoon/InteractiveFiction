using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InteractiveFiction
{
    internal class Program
    {
        static string[] story = File.ReadAllLines("Story.txt");



        static bool gameOver = false;


        
        
       

        static void Main(string[] args)
        {

            

            

            

            Console.ReadKey(true);
        }
        static void ShowCurrPage()
        {
            for (int currPageNum = 0; currPageNum < story.Length; currPageNum++)
            {
                Console.WriteLine(story[currPageNum]);

            }


        }
    }
}
