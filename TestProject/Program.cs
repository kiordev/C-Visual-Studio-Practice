using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Program
    {
        static void Main()
        {
            // База данных учеников
            Console.WriteLine("### CLASS A DATABASE ###");
            List<Classmate> classmates = new List<Classmate>();

            while(true)
            {
                Console.WriteLine("Choose a function:");
                Console.WriteLine("1 - Show Classmates");
                Console.WriteLine("2 - Add Classmates");
                Console.WriteLine("3 - Delete Classmates");
                Console.Write("Your variant: ");
                int userChoose = Convert.ToInt32(Console.ReadLine());
                if (userChoose == 1) {
                    ShowClassmates(classmates);
                    Console.WriteLine("Added new Classmate, any button to continue");
                    Console.ReadKey();
                }
                else if (userChoose == 2) {
                    Console.WriteLine("Введите данные ученика имя, фамилия, возраст");
                    string name = Console.ReadLine();
                    string surname = Console.ReadLine();
                    int age = Convert.ToInt32(Console.ReadLine());
                    AddClassmates(name, surname, age, classmates);
                }
                else if (userChoose == 3) { 
                    DeleteClassmates();
                }
                else {
                    Console.WriteLine("Entered a wrong number");
                }
                Console.Clear();
               
            }
        }

        public static void ShowClassmates(List<Classmate> classmates)
        {
            foreach (Classmate mate in classmates)
            {
                mate.showInfo();
            }
        }
        public static void AddClassmates(string name, string surname, int age, List<Classmate> classmates)
        {
            classmates.Add(new Classmate(name, surname, age));
        }
        public static void DeleteClassmates()
        {
            Console.WriteLine("3");
        }
    }


        
}

