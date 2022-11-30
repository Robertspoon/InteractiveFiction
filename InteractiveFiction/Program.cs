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
        static string story = File.ReadAllText("Story.txt"); //reads story from text file
        static string[] words = story.Split(';');//splits story at ";" point
        static string[] storyPages = story.Split('%');//splits story into pages by "%"
        static int currPageNum = 1;

        //static bool gameOver = false;
        static bool storyLoop = true;//Loops through story allowing gameplay


        
        
       

        static void Main(string[] args)
        {
            while(storyLoop ==true)
            {
                ShowCurrPage();
            }


            

           Console.ReadKey(true);
        }
        static void ShowCurrPage()//Shows the current page and allows you to go through story
        {



                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(storyPages[currPageNum].Split(';')[0]);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(storyPages[currPageNum].Split(';')[1]);

                if (storyPages[currPageNum].Split(';').GetLength(0) > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(storyPages[currPageNum].Split(';')[2]);

                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);

                    if (input.KeyChar == 'a')
                    {
                        currPageNum = Int32.Parse(storyPages[currPageNum].Split(';')[3]);
                    }
                    if (input.KeyChar == 'b')
                    {
                        currPageNum = Int32.Parse(storyPages[currPageNum].Split(';')[4]);
                    }
                    Console.Clear();
                }
                else
                {
                    Console.ReadKey(true);
                    storyLoop = false;
                }

            
        } 
        static void MainMenu()
        {

        }
    }
}
