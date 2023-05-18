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
            Console.WriteLine("Введите текст:");
            txt = Console.ReadLine();
            string lasttxt = firstpice(txt);
            Console.WriteLine(lasttxt);
            Console.ReadKey();
        }
        static string firstpice(string a)
        {
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
