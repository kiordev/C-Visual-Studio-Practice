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
            Human sasha = new Human();
            sasha.createHuman("Sasha", "Male", 22, 179, 100);
            sasha.printHumanInfo();
            sasha.setHumanHealth(90);
            sasha.printHumanInfo();

        }
    }


        
}

