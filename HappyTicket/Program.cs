using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumberOfTicket, maxNumberOfTicket;
            int simpleMethod = 0, difficaltMethod = 0;
            FindHappyTicket happy = new FindHappyTicket();

            Console.WriteLine("Введите минимальный номер билета");
            minNumberOfTicket = happy.Input();

            Console.WriteLine("Введите максимальный номер билета");
            maxNumberOfTicket = happy.Input();

            if (minNumberOfTicket < maxNumberOfTicket)
            {
                simpleMethod = happy.SimpleWay(minNumberOfTicket, maxNumberOfTicket);
                difficaltMethod = happy.DifficultWay(minNumberOfTicket, maxNumberOfTicket);
            }
            else if (minNumberOfTicket > maxNumberOfTicket)
            {
                simpleMethod = happy.SimpleWay(maxNumberOfTicket, minNumberOfTicket);
                difficaltMethod = happy.DifficultWay(maxNumberOfTicket, minNumberOfTicket);
            }


            if (simpleMethod > difficaltMethod) { Console.WriteLine("Победил простой способ!!!"); }
            else if (difficaltMethod > simpleMethod) { Console.WriteLine("Победил сложный способ!!!"); }
            else Console.WriteLine("Оба спосода дают одинаково кол-во счастливых билетов.");
            Console.ReadKey();
        }
    }
}
