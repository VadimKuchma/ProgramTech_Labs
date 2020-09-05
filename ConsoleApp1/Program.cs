using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ч1
            string labname = "Разработка консольного приложения";
            string labnumber = "Лаб №1";
            string name = "Кучма Вадим Григорьевич";
            string group = "ИНС-б-о-19-2";
            string spec = "09.03.02";
            string birth = "16.12.2000";
            string home = "c. Киевка";
            string obj = "Информатика";
            string hobby = "Чтение книг";


            Console.WriteLine(labname +" "+ labnumber+"\n" +name+ "\n" + group+", "+spec+"\n" + birth+ "\n"+ home + "\n" + obj + "\n" + hobby+"\n"+"\n");


            //ч2

            //int Zxy;
            int a_5 = 12;
            int b = 6;
            int y = 19;

           // Zxy = a_5 + b - a_5 * (b + y);

            Console.WriteLine("Значение переменной a_5 = {0}", a_5);
            Console.WriteLine("Значение переменной b = {0}", b);
            Console.WriteLine("Значение переменной y = {0}", y);
            Console.WriteLine("Результат выражения Zxy = {0}+{1}-{0}*({1}+{2}) равен {3}",a_5, b, y, a_5 + b - a_5 * (b + y));

            Console.ReadKey();
        }
    }
}
