using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Menu m = new Menu();
            ExamplesManager example = new ExamplesManager();
            do
            {
                Console.Clear();
                m.DisplayMenu();
                switch (m.GetChoice())
                {
                    case 1:
                        example.Example1();
                        break;
                    case 2:
                        example.Example2();
                        break;
                    case 3:
                        example.Example3();
                        break;
                    case 4:
                        example.Example4();
                        break;
                    case 5:
                        example.Example5();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        break;
                }
                if (exit) break;
            } while (m.Exit() == 'y');
            Console.WriteLine("\n Программа завершена (0_0) ");
        }
    }
}