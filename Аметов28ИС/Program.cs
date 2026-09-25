using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Аметов28ИС
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.FIO = "Иванов";
            st.Ocenka1 = 3;
            st.Ocenka2 = 5;
            st.Show();

            float sr = st.SredOcenka();
            Console.WriteLine($"Средняя оценка = {sr}");

            Console.ReadKey();



        }
    }
    class Student
    {
        private string fio;
        private int ocenka1;
        private int ocenka2;

        public string FIO
        {
            get
            {
                return fio;
            }
            set
            {
                fio = value;
            }
        }

        public int Ocenka1
        {
            get
            {
                return ocenka1;
            }
            set
            {
                if (value >= 2 && value <= 5) ocenka1 = value;
            }
        }
        public int Ocenka2
        {
            get
            {
                return ocenka2;

            }
            set
            {
                if (value >= 2 && value <= 5) ocenka2 = value;

            }
        }

        public Student()

        {
            FIO = "";
            Ocenka1 = 2;
            Ocenka2 = 2;
        }

        public Student(string f, int o1, int o2)
        {
            FIO = f;
            Ocenka1 = o1;
            Ocenka2 = o2;
        }

        public float SredOcenka()

        {

            float sr = (Ocenka1 + Ocenka2) / 2.0f;
            return sr;
        }

        public void Show()
        {
            Console.WriteLine($"Студент {FIO}, оценка1 = {Ocenka1}, оценка2 = {Ocenka2}");
        }
    }
}







    










