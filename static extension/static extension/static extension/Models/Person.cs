using System;
using System.Collections.Generic;
using System.Text;

namespace static_extension.Models
{
    public class Person
    {
        public int Age;

        public Person()
        {
            Age = 30;
            Console.WriteLine(Age);
        }
    }
}
