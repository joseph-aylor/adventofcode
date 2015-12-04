using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            int height = Console.WindowHeight;
            int width = Console.WindowWidth;

            //needs to be odd because we add two to the length each time.
            if (width % 2 == 0)
            {
                width--;
            }

            Console.CursorVisible = false;

            List<ConsoleColor> ornamentColors = new List<ConsoleColor>();

            ornamentColors.Add(ConsoleColor.Red);
            ornamentColors.Add(ConsoleColor.Blue);
            ornamentColors.Add(ConsoleColor.White);
            ornamentColors.Add(ConsoleColor.Yellow);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            /*for (int h = 0; h < height; h++)
            {
                for(int w = 0; w < width; w++)
                {
                    Console.Write("*");
                }
            }*/

            int treeHeight = 4;
            int treeWidth = 1;

            while (treeHeight < height && treeWidth < width)
            {
                for (int i = 0; i < (width / 2) - (treeWidth / 2); i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < treeWidth; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                treeHeight++;
                treeWidth += 2;
            }

            treeHeight--;
            treeWidth -= 2;

            for (int i = 0; i < (width / 2) - (5 / 2); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|   |");
            for (int i = 0; i < (width / 2) - (5 / 2); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|   |");
            for (int i = 0; i < (width / 2) - (5 / 2); i++)
            {
                Console.Write("_");
            }
            Console.Write("|___|");
            for (int i = 0; i < (width / 2) - (5 / 2); i++ )
            {
                Console.Write("_");
            }
                /*
                for (int i = 0; i < 10000; i-- )
                {
                    Random rand = new Random();
                    int w = rand.Next(0, width);
                    int h = rand.Next(0, height);
                    int colorIndex = rand.Next(ornamentColors.Count);
                    Console.ForegroundColor = ornamentColors[colorIndex];
                    Console.SetCursorPosition(w, h);
                    Console.Write("&");
                    Console.SetCursorPosition(w, h);
                    Console.Write("J");
                }
                */
                Console.ReadKey();
        }
    }
}
