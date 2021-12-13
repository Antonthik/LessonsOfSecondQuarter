using System;

namespace LessonsOfSecondQuarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson1_task1();
            Lesson1_task2();
            Lesson1_task3();
        }

        /// <summary>
        /// Проверка числа - является ли оно простым
        /// </summary>
        static void Lesson1_task1()
        {
            Console.WriteLine("Введите целое число");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }

                i++;

            }

            if (d == 0)
            {
                Console.WriteLine($"{number} - простое");
            }
            else
            {
                Console.WriteLine($"{number} - не простое");
            }


        }
        /// <summary>
        /// Данный алгоритм имеет три вложенных цикла, что дает сложность N(1)+N(i*j*(k*4)),
        /// где в цикле k вложено четыре операции, что приводит к увеличению. В тоже время элементарные
        /// операции вне циклов можно исключить из расчета, при больших размерностях циклов.
        /// </summary>
        static void Lesson1_task2()
        {
            //public static int StrangeSum(int[] inputArray)
            //{
            //    int sum = 0;  //N(1)
            //    for (int i = 0; i < inputArray.Length; i++) //N(i)
            //    {
            //        for (int j = 0; j < inputArray.Length; j++)//N(j)
            //        {
            //            for (int k = 0; k < inputArray.Length; k++)//N(k)
            //            {
            //                int y = 0;//N(1)
            //
            //                if (j != 0)//N(1)
            //                {
            //                    y = k / j;//N(1)
            //                }
            //
            //                sum += inputArray[i] + i + k + j + y;//N(1)
            //            }
            //        }
            //    }
            //
            //    return sum;
            //}

            Console.WriteLine("Сложность N(1)+N(i*j*(k*4))");

        }

        /// <summary>
        /// Нахождения числа Фибоначчи двумя способами(цмклом и рекурсией)
        /// 
        /// </summary>
        static void Lesson1_task3()
        {
            Console.WriteLine("Введите номер числа Фибоначчи.");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            if (num <= 0)
            {
                num = 1;
            }


            // используем класс FibNumber для расчета числа
            FibNumber fib = new FibNumber(num);
            fib.printFib();
            

        }


    }
}
