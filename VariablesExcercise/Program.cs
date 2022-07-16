using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Damion Russell";
            int age = 23;
            char firstInitial = 'D';
            bool isHuman = true;
            double aDouble = 20.0;
            decimal aDecimal =  21.1m;

            Console.WriteLine("Are you human? \n" + isHuman + "\n" + "State your name. \n" + name + "\n" + "State your age. \n"
                + age + "\n" + "His first initial is " + firstInitial + " average intelligence reading is " + aDouble + " but he's reading " + aDecimal);

            Console.ReadLine(); //This is just so console doesn't close after run



        }
    }
}
