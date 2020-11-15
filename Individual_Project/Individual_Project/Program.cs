using System;
using System.Collections.Generic;
using System.Linq;

namespace Hanoi
{
    public class Toh   // Программа автоматически решает поставленную задачу по пересборке Ханойских башен, предоставляя алгоритм
    {
        private readonly int N; //Я позже дам значение этим переменным, но сейчас я их объявил
        private readonly Stack<int>[] rods;

        public Toh(int n) // Конструктор класса.
        {
            N = n;
            rods = new Stack<int>[] { new Stack<int>(), new Stack<int>(), new Stack<int>() };
            for (int i = 0; i < n; i++)
            {
                rods[0].Push(n - i - 1);
            }
        }
        public void Solve() // Запускает функцию Solve
        {
            Draw();
            Solve(N);
        }
        private void Solve(int n) // Непосредственный алгоритм решения 
        {
            if (n == 0)
                return;

            Solve(n - 1);
            Move(n - 1);
            Draw();
            Solve(n - 1);
        }
        private int FindRod(int disk_size) // Нахождение палки, на котором находится диск
        {
            for (int i = 0; i < 3; i++)
            {
                if (rods[i].TryPeek(out int top) && top == disk_size) // Проверка последнего диска на палке и сохраняет последний диск в переменную top.
                    return i;
            }
            return -1;
        }
        private static int NextRod(int rod) // Смещение дисков вправо, со второго идет смещение на нулевой.
        {
            return (rod + 1) % 3;
        }
        private void Move(int disk_size) // Функция берет размер диска, потом сдвигает его 
        {
            int from_rod = FindRod(disk_size); // С какого стержня перекладываем
            int to_rod = NextRod(from_rod); // На какой стержень перекладываем
            if (rods[to_rod].TryPeek(out int top) && top < disk_size) //Смещение на ближайший справа стержень
                to_rod = NextRod(to_rod); // Смещение на следующий стержень, если справа стоит диск размером меньше

            int disk = rods[from_rod].Pop(); // Убираем диск
            rods[to_rod].Push(disk); // Вставляем диск
        }
        private void Draw() // Функция 
        {
            for (int i = 0; i < N; i++)
            {
                List<string> tops = new List<string>(); // Что в текущей линии будет стоять 
                foreach (Stack<int> rod in rods) // Перебираем по очереди стержни
                {
                    if (rod.Count >= N - i) // Прорисовка стержней
                        tops.Add(rod.ElementAt(rod.Count - (N - i)).ToString());
                    else
                        tops.Add("|");
                }
                Console.WriteLine($"{tops[0]}    {tops[1]}    {tops[2]}");
            }
            Console.WriteLine("");
        }
    }
    class Program
    {
        static void Main(string[] _)
        {
            int b = 0; // Задаём количество колец для алгоритма
            Console.Write("Введите количество колец на Ханойских башнях: ");
            try { b = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.WriteLine("Неправильный тип данных."); }
            var toh = new Toh(b);
            toh.Solve();
            return;
        }
    }
}