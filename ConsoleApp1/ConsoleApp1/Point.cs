using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point() {// создаем конструктор 
           }
        public Point(int _x, int _y, char _sym) {
            x =_x;
            y = _y;
            sym = _sym;
        }

        public void Draw () {

            Console.SetCursorPosition(x, y);// выводим координаты точек на экран
            Console.Write(sym);//выводим на экран sym1
        }
    }
}
