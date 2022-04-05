using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork
{
    class ExamplesManager
    {
        // 1->
        public void Example1()
        {
            int[] marks = new int[22];

            RandomFill(marks, 1, 12);
            Console.WriteLine($"\nAverage mark: {AverMark(marks):f2}");
            RemeberPosition(marks);
        }
        private void RandomFill(int[] marks, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = r.Next(min, max);
                Console.Write($"{ marks[i]} ");
            }
        }
        private double AverMark(int[] marks)
        {
            double sum  = 0.0;
            double aver = 0.0;
            for(int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            aver = sum / marks.Length;
            return aver;
        }
        public void RemeberPosition(int[]marks)
        {
            int pos = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < AverMark(marks))
                    pos++;
            }
            Console.WriteLine($"\n> Кол-ство учеников с оценкой, меньшей среднего: {pos}");
            //
            int[] position = new int[pos + 1];
            int j = 1;
            double aver = AverMark(marks);
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < aver)
                {
                    position[j] = i + 1; 
                    Console.WriteLine($" -> {position[j]}");
                    j++;
                }
            }
        }
        // 2->
        public void Example2()
        {
            int[] massive = new int[20];
            RandomFill(massive, 10, 99);
            int[] summas = new int[16];
            for(int i = 0; i < massive.Length; i++)
            {
                if((i + 4) < massive.Length)
                {
                        summas[i] = (massive[i] + massive[i + 1] + massive[i + 2] + massive[i + 3] + massive[i + 4]);
                }
                else { break; }
            }
            Array.Sort(summas);
            Console.WriteLine($"\n> Максимальная сумма 5 соседних чисел {summas[15]}");
        }
        // 3->
        public void Example3()
        {
            int[] massive = new int[10];
            //RandomFill(massive, 10, 99);
            InputData(massive);
            // 
            int[] difference = new int[10];
            for(int i = 0; i + 1 < massive.Length; i++)
            {
                    difference[i] = (massive[i] - massive[i + 1]);
                    Console.WriteLine(difference[i]);
            }

        }
        public void InputData(int[] massive)
        {
            int x = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($" Введите {i + 1}-е число: ");
                x = Convert.ToInt32(Console.ReadLine());
                massive[i] = x;
            }
        }
        // 4->
        public void Example4()
        {
            int[] massive = new int[15];
            //InputData(massive);
            RandomFill(massive, -10, 10);
            NegativeOrPositive(massive);
        }
        private void NegativeOrPositive(int[] massive)
        {
            int checker = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < 0)
                    checker++;
            }
            int[] negative = new int[checker]; int j = 0;      // Массив - чисел
            int[] positive = new int[15 - checker]; int x = 0; // Массив + чисел
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < 0)
                {
                    negative[j] = massive[i];
                    j++;
                }
                else
                {
                    positive[x] = massive[i];
                    x++;
                }
            }
            // Сортировка массива с негативными числами
            Console.WriteLine($"\n Новый массив: ");
            Array.Sort(negative);
            foreach (int i in negative)
                Console.Write($" {i}");
            // Сортировка массива с положительными числами
            Array.Sort(positive);
            Array.Reverse(positive);
            foreach (int i in positive)
                Console.Write($" {i}");
            //int[] newMassive = new int[15];
            Array.Copy(negative, massive, checker);
            positive.CopyTo(massive, checker);
        }
        // 5->
        public void Example5()
        {
            int[] mass1 = new int[12] { 1, 8, 54, 12, 35, 23, 54, 65, 4, 0, 13, 16 };
            int[] mass2 = new int[12] { 1, 8, 7, 8, 2, 35, 3, 8, 6, 7, 13, 18 };
            // Заполнение массивов рандомными числами
            Console.WriteLine("\n Массив №1 :");
            DisplayArray(mass1);
            Console.WriteLine("\n Массив №2 :");
            DisplayArray(mass2);
            // Конвертирование массивов в строки
            ReplaceNumbers(mass1, mass2);
        }
        private void DisplayArray(int[] mass)
        {
            foreach (int i in mass)
                Console.Write($" {i}");
        }
        private void ReplaceNumbers(int[] mass1, int[] mass2)
        {
            Console.WriteLine("");
            for(int i = 0; i < mass1.Length; i++)
            {
                if (mass1[i] == mass2[i]) { mass1[i] = 0; }
                Console.WriteLine(mass1[i]);
            }
        }
    }
}
