using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFIntoroduction.ConsoleApp
{   internal class Person
    {
        public Person()
        {
            this.Statement = "Good Mornimg";
        }
        public Person(string statement)
        {
            this.Statement = statement;
        }
        private string _statement;
        public string Statement { get; set; }
    }
}
