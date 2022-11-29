﻿using System;
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
        static string[] storyPages = story.Split('%');
        static int currPageNum = 1;

        static bool gameOver = false;
        static bool storyLoop = true;


        
        
       

        static void Main(string[] args)
        {

          while(storyLoop ==true)
          {


            Console.WriteLine(storyPages[currPageNum].Split(';')[0]);
            Console.WriteLine();
            Console.WriteLine(storyPages[currPageNum].Split(';')[1]);

            if (storyPages[currPageNum].Split(';').GetLength(0) > 2)
            {
              Console.WriteLine(storyPages[currPageNum].Split(';')[2]);

              ConsoleKeyInfo input;
               input = Console.ReadKey(true);

              if(input.KeyChar == 'a')
              {
               currPageNum = Int32.Parse(storyPages[currPageNum].Split(';')[3]); 
              }
              if (input.KeyChar == 'b')
              {
                currPageNum = Int32.Parse(storyPages[currPageNum].Split(';')[4]);
              }

            }
            else
            {
                 Console.ReadKey(true);
                    storyLoop = false;
            }


          }

            

            

           Console.ReadKey(true);
        }
        static void ShowCurrPage()
        {

            //Console.WriteLine(story.Split(';').Length);


        }


        static void MainMenu()
        {


        }
    }
}
