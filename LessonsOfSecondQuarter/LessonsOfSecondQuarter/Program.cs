using System;
using System.Collections.Generic;

namespace LessonsOfSecondQuarter
{
    class Program
    {
        static List<Interflesson> lessons = new List<Interflesson>()
        {
            new  Lesson1_task1(),
            new  Lesson1_task2(),
            new  Lesson1_task3(),
            new  Lesson2_task1(),
            new  Lesson3_task1(),
            new  Lesson4_task1(),
            new  Lesson4_task2()
        };
        static void Main(string[] args)
        {

            //Lesson1_task1();
            Console.WriteLine($"Список доступных уроков:");
            foreach (Interflesson lesson in lessons)
            {
                Console.WriteLine($"имя: {lesson.NameLesson} описание:{lesson.Discription}");
            }

            Console.WriteLine($"Введите имя урока для запуска:");
            string input = Console.ReadLine();

            foreach (Interflesson lesson in lessons)
            {
                if (input == lesson.NameLesson)
                {
                    lesson.Demo();
                }
                

            }


    
        }


        
        

    }
}
