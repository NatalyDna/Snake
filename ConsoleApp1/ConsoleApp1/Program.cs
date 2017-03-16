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
            Point p1 = new Point(1,3,'*');//делаем перенос из нового класса в основной проект

            p1.Draw();// и выводим на экран

            Point p2 = new Point(4,5,'#');//делаем перенос из нового класса в основной проект
           
            p2.Draw();// и выводим на экран

           Console.ReadLine();// выход,после нажатия клавиши enter






        }
    }
}
            
