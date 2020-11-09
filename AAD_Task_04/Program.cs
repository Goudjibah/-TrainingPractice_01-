using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAD_Task_04
{

    class Progaram
    {
        static void Main(string[] args)
        {
            Random HpB = new Random();
            Random HpP = new Random();

            int HpBoss = HpB.Next(200, 700);  // Случайное здоровье Дарта Вейдера
            int HpPlayer = HpP.Next(225, 500); // Случайное здоровье Люка Скайуокера
            int UltimateDamage = 0; // Если равно 3, приходит R2D2
            bool Attack = false;
            Random bsd = new Random(); // Создание рандома для урона Дарта Вейдера
            Random hlp = new Random(); // Создание рандома для прибавления здоровья
            Random kam = new Random(); // Создание рандома для пропуска хода Дарта Вейдера от третьего умения
            Console.WriteLine("Протагонистом игры является Люк Скайуокер. Вы находитесь на повстанческой миссии в Облачном Городе на планете Беспин.\n");
            Console.WriteLine("Вас взял в расплох Дарт Вейдер! Вас и ваших союзников разделили, вам придется дать ему бой. \n");
            Console.WriteLine("Победите Дарта Вейдера! \n");
            Console.WriteLine("Ваша атака проходит после атаки Дарта Вейдера.\n");
            Console.WriteLine("Вы сталкиваетесь с таким сильным противником впервые, так что получаемый урон будет варьироваться от 20 до 80 единиц здоровья.\n");
            do
            {



            chooseAgain:
                Console.WriteLine($"Ваше здровье: {HpPlayer}");
                Console.WriteLine($"Здоровье Дарта Вейдера: {HpBoss}\n");
                Console.Write("Выберете действие:\n" +
                "1.Замах световым мечом (20 урона) \n" +
                "2.Толчок силы (Выводит из строя схемы Дарта Вейдера. Если вас атаковали, у вас есть время использовать стим (+70 Здоровья)).Шанс 50%!.Вколоть препарат можно при потереи здоровья ниже 200\n" +
                "3.Бросок предмета силой, наносит урон в 80 единиц здоровья (При попадании с 50% вероятность оглушает Дарта Вейдера на 1 ход)\n" +
                "4.Вы можете позвать на помощь своего дроида, R2D2. Он начнет атаковать врага с помощью взломанных турелей. Связь не позволяет вам его позвать сразу, нужно будет сделать это три раза.\n" +
                "5.Команда R2D2 атаковать Дарта Вейдера  \n");


                int spell = 0;
                try { spell = Convert.ToInt32(Console.ReadLine()); } // Если Игрок ввел неверный тип данных
                catch
                {
                    Console.WriteLine("Неверный тип данных.");
                    goto chooseAgain;
                }
                Console.Clear();

                int BossDamage = bsd.Next(20, 80); // Значение наносимого урона Дартом Вейдером
                int chanseHelp = hlp.Next(0, 2);  // 50% шанс на использование лечебного препарата
                int stun = kam.Next(0, 2); // 50% шанс оглушение Дарта Вейдера


                switch (spell) // Выборка 
                {
                    case (1):
                        HpBoss -= 20;
                        break;
                    case (2):
                        if (chanseHelp == 1 && Attack == true)
                        {
                            Console.WriteLine("Дарт Вейдер выведен из строя!");
                            BossDamage = 0;
                            if (HpPlayer < 200) // проверка на количество здоровья игрока и возможность использования препарата
                            {
                                HpPlayer += 70;
                            }


                        }

                        break;
                    case (3):
                        if (stun == 1)
                        {
                            Console.WriteLine("Схемы Дарта Вейдера замкнуло!\n");
                            BossDamage = 0;
                        }
                        HpBoss -= 80;
                        break;
                    case (4): // при достижении 3 вызывается R2D2
                        UltimateDamage = UltimateDamage + 1;


                        if (UltimateDamage > 3)
                        {
                            Console.WriteLine("R2D2 уже здесь! Вы пропускаете ход");

                        }
                        if (UltimateDamage == 3)
                        {
                            Console.WriteLine("R2D2 прибыл и с помощью взломанной турели нанёс 90 единиц урона Дарту Вейдеру!\n");
                            HpBoss -= 90;


                        }
                        break;
                    case (5):
                        HpBoss -= 90;

                        break;

                    default:
                        Console.WriteLine("Дарт Вейдер воспользовался вашим бездействием и нанёс свой удар!");
                        break;


                }

                HpPlayer -= BossDamage;
                Attack = true;




            } while (HpBoss > 0 && HpPlayer > 0); // конец битвы при отсутствии здоровья 
            if (HpPlayer <= 0)
            {
                Console.WriteLine("Дарт Вейдер почти убил вас, но вы с позором сбежали с поля боя, потеряв световой меч и руку.");
                Console.ReadKey();

            }
            else if (HpBoss <= 0)
            {
                Console.WriteLine("Вы чудом одолели Лорда Ситхов, выведя из строя его систему жизнеобеспечения, и взяли его в плен. Это огромный шаг к победе для сопротивления!");
                Console.ReadKey();

            }
        }

    }
}

