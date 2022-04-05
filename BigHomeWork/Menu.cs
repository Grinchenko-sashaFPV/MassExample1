using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork
{
    class Menu
    {
        int choice;
        public void DisplayMenu()
        {
            Console.WriteLine(" ==============================================");
            Console.WriteLine(" 1 -> Задача про учеников");
            Console.WriteLine(" 2 -> Задача про массив из 20-ти элементов");
            Console.WriteLine(" 3 -> Задача про ввод нового массива из 10-ти элементов");
            Console.WriteLine(" 4 -> Задача про ввод нового массива из 15-ти элементов");
            Console.WriteLine(" 5 -> Задача про замену чисел в в массиве с 12 элементами");
            Console.WriteLine(" 6 -> Выход");
            Console.WriteLine("==============================================");

        }
        public int GetChoice()
        {
            Console.Write(" Выберите нужное действие: -> ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            return choice;
        }
        public char Exit()
        {
            char ans;
            Console.Write("\n> Продолжить? (y/n) -> ");
            ans = Convert.ToChar(Console.ReadLine());
            return ans;
        }
    }
}
