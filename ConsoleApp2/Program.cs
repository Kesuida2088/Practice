using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFIntoroduction.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Hello");

            Console.WriteLine(person.Statement);
            person.Statement = "こんにちは";
            Console.WriteLine(person.Statement);

            Console.WriteLine("何かキーを押してください");
            Console.ReadKey();
        }
    }
}