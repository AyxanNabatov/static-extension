using System;
using System.Collections.Generic;
using System.Text;

namespace static_extension.Models
{
    public class Car
    {
        //public int Speed { get; set; } 

        //public static int Speed { get; set; }
        public static int Speed;
        //public static int Speed = 300;

        static Car()
        {
            Speed = 500;

            Console.WriteLine(Speed);
        }
        //public Car()
        //{
        
        //}

        //public static void ShowSpeed()
        //{
        //    Console.WriteLine(Speed);
        //}

        //public static int ShowSpeed()
        //{
        //    return Speed;
        //}

        
    }
}
