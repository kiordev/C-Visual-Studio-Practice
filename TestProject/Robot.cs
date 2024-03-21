using System;


namespace TestProject
{
    class Robot
    {
        public string name;
        public int weight;
        public byte[] cord;

        public void setValues(string _name, int _weight, byte[] _cord)
        {
            name = _name;
            weight = _weight;
            cord = _cord;
        }

        public void printValues()
        {
            Console.WriteLine(name + weight);
            foreach (byte el in cord) {
                Console.WriteLine(el);
            }
        }
    }
}
