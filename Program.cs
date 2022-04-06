using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample040422
{
    class Program
    {
        static void Main(string[] args)
        {
            clsAnketa anketa = new clsAnketa(); //объект класса
            anketa.FIO = "Кузьмина Е.Е.";
            anketa.Kurs = 5;
          
            Console.WriteLine(anketa.PrintInfo());

            clsAnketa anketa1 = new clsAnketa("Немтырева К.А.", 
                 "Ликино-Дулево", 2, "ИСП.20А", "+79771801465");

            Console.WriteLine(anketa1.PrintInfo());

            //создание массива объектов
            Console.WriteLine("Введите количество студентов N=");
            int N = int.Parse(Console.ReadLine());

            clsAnketa[] anketas = new clsAnketa[N];
            for(int i = 0; i<N; i++)
            {
                anketas[i] = new clsAnketa();
                anketas[i].FIO = Console.ReadLine();
                anketas[i].Kurs = byte.Parse(Console.ReadLine());
               
            }
            foreach(clsAnketa cls in anketas)
            {
                Console.WriteLine(cls.PrintInfo());
            }
            Console.ReadKey();
;        }
    }
}
