using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "";
            int i = 0;
            Console.WriteLine("Введите текст:");
            txt = Console.ReadLine();
            Console.WriteLine("Выберите вариант: \n1. Перевернуть текст \n2. Посчитать кол-во гласных");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
               string lasttxt = firstpice(txt);
               Console.WriteLine(lasttxt);
                    break;

                    case 2:
                    int znach = secondpice(txt);
                    Console.WriteLine("Кол-во глассных = " + znach);
                    break;
            }
            
            Console.ReadLine();
        }
        static string firstpice(string a)
        {
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static int secondpice(string a)
        {
            const string glas_lett = "АаЕеЁёИиОоУуЭэЮюЯяAaEeYyUuIiOo";
            int cnt = 0;
            for (int i = 0; i < a.Length; ++i)
                for (int j = 0; j < glas_lett.Length; ++j)
                    if (a[i] == glas_lett[j])
                        ++cnt;
            return cnt;
        }
    }
}
