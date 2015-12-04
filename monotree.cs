using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSharp
{
    class Ornament
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public char OrnamentDisplay { get; set; }

        public Ornament(int row, int column, char ornament)
        {
            this.Row = row;
            this.Column = column;
            this.OrnamentDisplay = ornament;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // This is quite possible the worst code I've ever written.

            List<ConsoleColor> ornamentColors = new List<ConsoleColor>();

            ornamentColors.Add(ConsoleColor.Red);
            ornamentColors.Add(ConsoleColor.Blue);
            ornamentColors.Add(ConsoleColor.White);
            ornamentColors.Add(ConsoleColor.Yellow);

            List<char> ornaments = new List<char>();

            ornaments.Add('*');
            ornaments.Add('@');
            ornaments.Add('0');
            ornaments.Add('O');
            ornaments.Add('o');

            ConsoleColor treeColor = ConsoleColor.Green;
            ConsoleColor backgroundColor = ConsoleColor.Black;

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = treeColor;

            Console.Clear();

            int height = Console.WindowHeight;
            int width = Console.WindowWidth;

            //needs to be odd because we add two to the length each time.
            if (width % 2 == 0)
            {
                width--;
            }

            Console.CursorVisible = false;

            int treeHeight = 4;
            int treeWidth = 1;

            List<Ornament> ornamentLocations = new List<Ornament>();

            while (treeHeight < height && treeWidth < width)
            {
                for (int i = 0; i < (width / 2) - (treeWidth / 2); i++)
                {
                    Console.Write(" ");
                }
                bool previousIsOrnament = false;
                for (int i = 0; i < treeWidth; i++)
                {
                    // Using a guid as a seed makes random seem more random, not so based on time.
                    Random isOrnament = new Random(Guid.NewGuid().GetHashCode());
                    
                    if(treeWidth == 1)
                    {
                        Console.ForegroundColor = ornamentColors[isOrnament.Next(ornamentColors.Count)];
                        Console.Write('*');
                        Console.ForegroundColor = treeColor;
                        previousIsOrnament = true;
                        ornamentLocations.Add(new Ornament(treeHeight - 4, i, '*'));
                    }
                    else if(i !=0 && i != treeWidth -1 && isOrnament.Next(3) == 0 && !previousIsOrnament)
                    {
                        int ornamentIndex = isOrnament.Next(ornaments.Count);
                        Console.ForegroundColor = ornamentColors[isOrnament.Next(ornamentColors.Count)];
                        Console.Write(ornaments[ornamentIndex]);
                        Console.ForegroundColor = treeColor;
                        previousIsOrnament = true;
                        ornamentLocations.Add(new Ornament(treeHeight - 4, i, ornaments[ornamentIndex]));
                    }
                    else if(i < treeWidth/2)
                    {
                        Console.Write('>');
                        previousIsOrnament = false;
                    }
                    else
                    {
                        Console.Write('<');
                        previousIsOrnament = false;
                    }
                }
                for (int i = 0; i < (width / 2) - (treeWidth / 2); i++)
                {
                    Console.Write(" ");
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
            Console.Write("|   |");
            for (int i = 0; i < (width / 2) - (5 / 2); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("");
            for (int i = 0; i < (width / 2) - (5 / 2); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|   |");
            for (int i = 0; i < (width / 2) - (5 / 2); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("");
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
