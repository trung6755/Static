using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.Change();
            Student studenA = new Student(100, "Goku");

            
            studenA.Display();
            Console.ReadKey();
        }
    }
}
