using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OOPSConcept
{
    class ClassRoom
    {
        string text = "I have apples each costing RS";
        public ClassRoom(int i)
        {
            Console.WriteLine(text +  + i);
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            ClassRoom newObj = new ClassRoom(10);
            Console.ReadLine();

        }
    }
}