using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Classmate
    {
        public string name;
        public string surname;
        public int age;

        public Classmate(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void showInfo()
        {
            Console.WriteLine($"Name:{name} Surname: {surname} Age: {age}");
        }
    }
}
