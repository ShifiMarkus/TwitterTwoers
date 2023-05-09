using System;

namespace StringManipulation
{
    class Program

    {
        const int DIFF = 5;
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose which building you want to build:");
            Console.WriteLine("1) A rectangular building");
            Console.WriteLine("2) A triangular building");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    checkRectangel(SetWidthAndHeight());
                    return true;
                case "2":
                    checkTringal(SetWidthAndHeight());
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static WidthAndHeight SetWidthAndHeight()
        {
            WidthAndHeight widthAbdHeight = new WidthAndHeight();
            Console.WriteLine("Please enter height");
            widthAbdHeight.height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter width");
            widthAbdHeight.width = int.Parse(Console.ReadLine());

            return widthAbdHeight;
        }

        private static void checkRectangel(WidthAndHeight widthAndHeight)

        {
            if (widthAndHeight.height == widthAndHeight.width || Math.Abs(widthAndHeight.width - widthAndHeight.height) > DIFF)
            {
                Console.WriteLine(widthAndHeight.width * widthAndHeight.height);
            }
            else
            {
                Console.WriteLine(widthAndHeight.height * 2 + widthAndHeight.width * 2);
            }
            Console.ReadLine();
        }

        private static void checkTringal(WidthAndHeight widthAndHeight)
        {
            Console.Clear();
            Console.WriteLine("Choose what you want to calculate for the triangle:");
            Console.WriteLine("1) Perimeter of the triangle");
            Console.WriteLine("2) The triangle print");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    PerimeterOfTheTriangle(widthAndHeight);
                    break;
                case "2":
                    TheTrianglePrint(widthAndHeight);
                    break;
                default:
                    break;
            }
        }

        private static void TheTrianglePrint(WidthAndHeight widthAndHeight)
        {

            if (widthAndHeight.width % 2 == 0 || widthAndHeight.width > widthAndHeight.height * 2)
            {
                Console.WriteLine("Sorry, but we can't print the triangle");
                Console.ReadLine();
            }
            else
            {
                int cnt = (widthAndHeight.height) / ((widthAndHeight.width - 2 + 1)/2);
                int rem = (widthAndHeight.height) - cnt * ((widthAndHeight.width - 2) /2) -2 ;
                int space = widthAndHeight.width / 2;
                for (int i = 1; i < 2; i++)
                {
                    int numAsterisks = 1 + (i - 1) * 2;
                    Console.Write(new string(' ', space--));
                    Console.WriteLine(new string('*', numAsterisks));
                }
                for(int i = 1; i <= rem + cnt; i++) 
                {
                    Console.Write(new string(' ', space));
                    Console.WriteLine(new string('*', 3));
                }
                
                for(int i=5; i<widthAndHeight.width; i+=2)
                {
                    space--;
                    for (int j = 1; j <= cnt; j++)
                    {
                        Console.Write(new string(' ', space));
                        Console.WriteLine(new String('*', i));
                    }
                }
                for (int i = 0; i >= 0; i--)
                {
                    int numAsterisks = widthAndHeight.width - i * 2;
                    Console.WriteLine(new string('*', numAsterisks));
                }

            }
            Console.ReadLine();
            
        }
        public static void PrintTriangle(int width, int height)
        {
            if (width % 2 == 0 || width > height * 2)
            {
                Console.WriteLine("Cannot print triangle.");
                return;
            }

            int mid = height / 2;
            int baseWidth = width;

            for (int row = 0; row < height; row++)
            {
                int stars = row <= mid ? row * 2 + 1 : (height - row - 1) * 2 + 1;
                int spaces = (baseWidth - stars) / 2;

                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void PrintRow(int stars, int width)
            {
                int spaces = (width - stars) / 2;
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            private static void PerimeterOfTheTriangle(WidthAndHeight widthAndHeight)
            {
                Console.WriteLine(widthAndHeight.width + widthAndHeight.height * 2);
                Console.ReadLine();
            }
        
    }
    class WidthAndHeight
    {
        public int width { get; set; }
        public int height { get; set; }
    }
}
