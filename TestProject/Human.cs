using System;
using System.Data.SqlClient;


namespace TestProject
{
    class Human
    {
        public string name;
        public string sex;
        public int age;
        public int height;
        public int health;

        public void createHuman(string _name, string _sex, int _age, int _height, int _health)
        {
            name = _name;
            sex = _sex;
            age = _age;
            height = _height;
            health = _health;
            
        }

        public void printHumanInfo()
        {
            Console.WriteLine($"Имя: {name } Пол: {sex} Возраст: {age} Высота: {height} Здоровье: {health}");
        }

        public void setHumanHealth(int _health)
        {
            health = _health;
            Console.WriteLine("Уровень здоровья изменен");
        }
    }
}
