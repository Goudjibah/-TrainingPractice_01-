using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AAD_Task_05

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int[,] maze = new int[,]     //Паттерн лабиринта
            {
{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
{1,0,1,0,1,0,1,0,0,0,1,0,1,0,0,2,0,0,0,0,0,0,0,0,1,0,0,0,1},
{1,0,1,2,1,0,1,0,1,1,1,0,1,0,1,1,1,1,1,0,1,1,1,0,1,1,1,0,1},
{1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,1},
{1,0,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,0,1,1,1,1,1,0,1,0,1},
{1,0,1,0,1,0,0,0,0,0,1,0,0,0,0,0,1,0,1,0,1,0,0,0,0,0,1,0,1},
{1,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,0,1,0,1,0,1},
{1,0,0,0,0,0,1,0,1,0,1,0,1,0,0,0,0,0,0,0,1,0,0,0,1,0,1,0,1},
{1,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,0,1,1,1,0,1},
{1,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,1,0,1,0,1},
{1,0,1,1,1,2,1,0,1,1,1,1,1,1,1,0,1,0,1,1,1,0,1,1,1,0,1,1,1},
{1,0,0,0,1,0,1,0,1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,1},
{1,0,1,1,1,0,1,0,1,1,1,0,1,0,1,0,1,0,1,1,1,0,1,1,1,1,1,0,1},
{1,0,1,0,0,0,1,0,1,0,0,0,1,0,1,0,1,0,1,0,0,0,0,0,1,0,0,0,1},
{1,0,1,1,1,1,1,1,1,0,1,0,1,1,1,0,1,1,1,1,1,0,1,0,1,1,1,0,1},
{1,0,1,0,0,0,1,0,1,0,1,0,0,0,0,0,1,0,0,0,0,0,1,0,1,0,1,0,1},
{1,1,1,1,1,0,1,0,1,1,1,0,1,1,1,0,1,1,1,0,1,1,1,0,1,0,1,1,1},
{1,0,0,0,1,0,0,2,0,0,0,0,1,0,1,0,0,2,1,0,0,0,1,0,0,0,0,0,1},
{1,1,1,0,1,0,1,1,1,1,1,0,1,0,1,0,1,0,1,1,1,1,1,0,1,0,1,1,1},
{1,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,0,0,1,0,1,0,0,0,1},
{1,1,1,0,1,1,1,1,1,0,1,1,1,0,1,0,1,1,1,0,1,0,1,1,1,0,1,1,1},
{1,0,0,0,0,0,1,0,1,0,1,0,0,0,1,0,0,0,1,0,1,0,1,0,0,0,0,0,1},
{1,1,1,0,1,1,1,0,1,0,1,0,1,0,1,0,1,1,1,0,1,1,1,1,1,0,1,1,1},
{1,0,0,2,0,0,0,0,1,0,1,0,1,0,1,0,0,0,1,0,1,0,0,0,0,0,0,0,1},
{1,1,1,0,1,1,1,0,1,0,1,1,1,2,1,0,1,1,1,0,1,1,1,0,1,0,1,0,1},
{1,0,1,0,0,0,1,0,1,0,0,0,1,0,1,0,1,0,1,0,1,0,0,0,1,0,1,0,1},
{1,0,1,0,1,0,1,1,1,0,1,1,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,0,1},
{1,0,0,0,1,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,2,1,0,0,0,0,0,0},
{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}



            };

            int x = 1, y = 1; //Х и У - координаты Игрока
            int i = 0;
            int j = 0;
            Console.WriteLine("Играя со своими братьями и сестрами, вы потерялись в саду. Уже темнеет, и вам лучше побыстрее найти выход из лабиринта." +
                "\nМама наругает, если мы опоздаем к ужину.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\nВ любой момент времени, вы можете позвать на помощь взрослых, нажав на клавишу Esc");
            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        Again:
            x = 1;
            y = 1;
            try
            {



                while (true)  //Прорисовка Лабиринта путем бесконечного цикла
                {
                    Console.Clear();


                    for (i = 0; i < maze.GetLength(0); i++)
                    {
                        for (j = 0; j < maze.GetLength(1); j++)
                        {
                            if (maze[i, j] == 0) Console.Write("*");
                            if (maze[i, j] == 1) Console.Write("▒");
                            if (maze[i, j] == 2) Console.Write("۩");
                        }

                        Console.WriteLine();
                    }
                    Console.Write("\n Найди выход!");


                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("☻");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;



                    ConsoleKeyInfo ki = Console.ReadKey(); // Обработка управления с клавиатуры
                    if (ki.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine(" Вы громко крикнули, и на поиски вас отправились взрослые" +
                            "\nМама не оценила вашу глупость и запретила играть в саду!");
                        Console.ReadKey();
                        break;




                    }

                    if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 0) x--;

                    if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 0) x++;

                    if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 0) y--;

                    if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 0) y++;

                    if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 2) goto Dead;

                    if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 2) goto Dead; ;

                    if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 2) goto Dead; ;

                    if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 2) goto Dead; ;

                }

            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine("Поздравляю! Вы пришли домой к ужину!");
                Console.ReadKey();
                Environment.Exit(0);
            }

        Dead:
            Console.Clear();
            Console.WriteLine("В спешке вы споткнулись о корень, торчащий из земли.");
            Console.ReadKey();
            Console.WriteLine("\nС размаху вы упали в куст шимповника, и очень громко закричали от боли и испуга.");
            Console.WriteLine("\nВам грустно, больно и страшно, к тому же становится совсем темно...");
            Console.ReadKey();
            Console.WriteLine("\nПродолжая беспорядочное движение вперед, вы натыкаетесь на маму. Она обнимает вас и отводит домой.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nИгра окончена. Нажмите любую клавишу для повтора попытки.");
            Console.ReadKey();

            goto Again;
        }
    }
}
