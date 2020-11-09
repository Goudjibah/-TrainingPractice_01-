using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAD_Task_02
{

    class Program
    {


        static void Main(string[] args)
        {
            string slovo = " "; // "Обнуляем" переменную

            do
            {

                slovo = Console.ReadLine();

            }
            while (slovo != ("exit"));
        }
    }
}
