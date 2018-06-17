using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTicket
{
    public class FindHappyTicket
    {
        int sum1, sum2;
        int MIN;
        int leng, leng2;        

        public int SimpleWay(int min, int max)
        {
            while (min <= max)
            {
                MIN = min;
                for (int i = 0; i < 6 / 2; i++)
                {
                    sum1 += MIN % 10;
                    MIN /= 10;
                }
                for (int j = 6 / 2; j < 6; j++)
                {
                    sum2 += MIN % 10;
                    MIN /= 10;
                }
                if (sum1 == sum2)
                {
                    leng++;
                }                
                sum1 = 0;
                sum2 = 0;
                min++;
            }
            Console.WriteLine("Простой способ находит: " + leng + " счатливых билетов");
            return leng;
        }

        public int DifficultWay(int min, int max)
        {
            while (min <= max) {
                MIN = min;
                for (int i = 0; i < 6; i++)
                {
                    if ((MIN % 10) % 2 == 0)
                    {
                        sum1 += MIN % 10;
                        MIN /= 10;
                    }
                    else
                    {
                        sum2 += MIN % 10;
                        MIN /= 10;
                    }                    
                }
                if (sum1 == sum2)
                {
                    leng2++;
                }
                sum1 = 0;
                sum2 = 0;
                min++;
            }
            Console.WriteLine("Сложный способ находит: " + leng2 + " счатливых билетов");
            return leng2;
        }

        public int Input()
        {
            int input;
            string tmp = Console.ReadLine();
            if (!Int32.TryParse(tmp, out input))
            {
                Console.WriteLine("Введен неправильный формат!\n Введите повторно.");
                Input();
            }
                          
            return input;
        }
    }
}
