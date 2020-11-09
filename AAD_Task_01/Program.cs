using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAD_Task_01
{

    class Program
    {

        public const int Dimonds_cost = 100;   //Стоимость 1 кристалла


        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше количество золота: ");
            int Gold = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Какое количество кристаллов вы обменяете? Курс 1 кр. = {Dimonds_cost} золота");
            int Dimonds = Convert.ToInt32(Console.ReadLine());


            try
            {
                int calculation = Gold - Dimonds * Dimonds_cost;
                int[] arr = new int[Gold + 1];
                arr[calculation] = 1;
                Console.WriteLine($"Успешно. Теперь у вас {calculation} золота и {Dimonds} кристаллов.");

                Console.ReadKey();
            }
            catch (Exception e)            // дебаг
            {
                Console.WriteLine($"Недостаточно золота для транзакции! \n{Gold} золота и 0 кристалл(ов).");

                int fail = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
            };
        }
    }


}

