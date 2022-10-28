using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework
{
    abstract class Person // все люди
    {
        public string name { get; set; }
        public Person(string Name)
        {
            name = Name; //потому что разные регистр
        }
    }
    class Sender : Person //отправитель груза
    {
        public string surname { get; set; } //фамилия отправителя
        public string patronymic { get; set; } // отчество отправителя
        public string phonenumber { get; set; } // контактный номер
        public string companyesnder { get; set; } // компания отправителя
        //public Sender(string Name) : base(Name) { }
        public Sender(string surname, string name, string patronymic)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
        }

    }
    class recipient : Person //получатель груза
    {
        public string surname { get; set; } //фамилия получателя 
        public string patronymic { get; set; } // отчество получателя товара
        public string phonenumber { get; set; } // контактный номер
        public byte age { get; set; } // возраст получателя товара
        public byte experience { get; set; } //стаж получателя
        public recipient(string Name) : base(Name) { }

    }
    class Cargo //груз
    {
        public ushort weight { get; set; }//вес груза в ushort потому что вес не можеть быть минусовым
        public ushort length { get; set; }// длина груза
        public ushort width { get; set; }// ширина груза
        public ushort height { get; set; }// высота груза
        public bool fragility { get; set; }// хрупкость (да или нет)
        public ushort pricecargo { get; set; } // стоимость груза
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
