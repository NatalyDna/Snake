using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Draw(x2, y2, sym2);

            Console.ReadLine();// выход,после нажатия клавиши enter


        }
        static void Draw(int x, int y, char sym) {// повторяющиеся куски кода выносятся в отдельную функцию
            Console.SetCursorPosition(x, y);// выводим координаты точек на экран
            Console.Write(sym);//выводим на экран sym1
            
        }
    }
}
    
            
