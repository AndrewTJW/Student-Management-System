using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Person
    {
        private string gender { get; set; }
        private int age { get; set; }

        public Person(string a_gender, int a_age)
        {
            gender = a_gender;
            age = a_age;
        }

        public Person (string a_gender)
        {
            if (a_gender.ToUpper() != "MALE" && a_gender.ToUpper() != "FEMALE")
            {
                gender = a_gender;
            }
            else
            {
                Console.WriteLine("Invalid gender!");
            }
        }

        public Person() { }

    }
}
