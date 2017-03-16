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
            Point p1 = new Point();//делаем перенос из нового класса в основной проект
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();// и выводим на экран

            Point p2 = new Point();//делаем перенос из нового класса в основной проект
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();// и выводим на экран

           Console.ReadLine();// выход,после нажатия клавиши enter






        }
    }
}
            
