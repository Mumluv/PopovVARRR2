using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopovVARRR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
            // Task8();
            // Task9();
            Task10();
            // Task11();
            

            void Task1()
            {
                int i = 0;
                while ( ++i <= 10) {
                    Console.WriteLine(i);                      
            }
            }

            void Task2()
            {
                int i = 0;
                Console.WriteLine("Введите количетсво раз вывода строки: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Строка: ");
                string str = Console.ReadLine();
                while ( ++i <= n) {
                    Console.WriteLine(str);
                    
                }
            }
            
            void Task3()
            {
                int i = 0;
                while (++i < 10)
                {
                    int j = 0;
                    while (++j < 10)
                    {
                        Console.Write("S");
                    }
                    Console.WriteLine();
                }

            }

            void Task4()
            {
                int i = 1;
    
                while (i <= 10)
                {
                    int j = 1;
                    while (j <= 10)
                    {
                        Console.Write(i * j + " ");
                        j++;
                     }
                    Console.WriteLine();
                    i++;
                }
                
            }

            void Task5()
            {
                for (int i = 0; i <= 100; ++i)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            void Task6()
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= m - 1; ++i)
                {
                    for(int j = 0; j <= n - 1; ++j)
                    {
                        Console.Write("8");
                    }
                    Console.WriteLine();
                }
            }

            void Task7()
            {
                for (int i = 1; i <= 10; ++i)
                {
                    for (int j = 0; j < i; ++j)
                    {
                        Console.Write("8");
                    }
                    Console.WriteLine();
                }
            }

            void Task8()
            {
                for (int i = 1; i < 10; ++i)
                {
                    Console.Write("8");
                }
                for (int j = 0; j < 11; ++j)
                {
                    Console.WriteLine("8");
                }
            }

            void Task9()
            {
                for (int i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Я никогда не буду работать за копейку.");
                }
            }

            void Task10()
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 == num2 && num2 == num3) {
                    Console.WriteLine(num1);
            } else if (num1 > num2)
                {
                    
                }
            }
            
            void Task11()
            {
                Console.WriteLine("Как тебя зовут? ");
                string Name = Console.ReadLine();
                Console.WriteLine("Введите день своего рождения ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите месяц своего рождения ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год своего рождения ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Меня зовут " + Name);
                Console.WriteLine("Я родился " + day + "." + month + "." + year);   
            }
           
        }
    }
}
