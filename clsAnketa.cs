using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample040422
{
    class clsAnketa
    {//поля класса
        private string fio;
        private DateTime birthday;
        private string adress;
        private byte kurs;
        private string group;
        private string phone;
        // свойства для доступа к полям
        public string FIO
        {
            get { return  fio; }
            set { fio = value; }
        }
        public byte Kurs
        {
            get { return kurs; }
            set { kurs = value; }
        }
        //методы 
        //конструктор без параметров
        public clsAnketa()
        {
            kurs = 1;
            group = "ИСП.22А";
            phone = "+70000000000";
        }
        //конструктор с параметрами
        public clsAnketa(string f,  string ad, int year, int month, int day,
            byte k, string g, string ph)
        {
            fio = f;
            birthday = new DateTime(year, month, day);
            adress = ad;
            kurs = k;
            group = g;
            phone = ph;
        }
        //вывод информации об объекте
        public string PrintInfo()
        {
            return $"Студент: {fio}  Дата рождения {birthday} " + 
                $"Курс: {kurs} " +
                $"Группа: {group} " +
                $"Телефон: {phone}";
        }

    }
}
