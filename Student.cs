using System;
using System.Runtime.CompilerServices;

namespace Static
{
    public class Student
    {
        private int id;
        private string name;
        private static string uni = "HUST";

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static void Change()
        {
            uni = "USTH";
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + uni);
        }
    }
}
