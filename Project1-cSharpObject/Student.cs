using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    public class Student
    {
        public int Id { get; private set; }

        public string Name { get; private set; }
        
        public int Age { get; private set; }

        public char AvarageGrade { get; private set; }

        public Student(int id, string name, int age, char averageGrade )
        {
            Id = id;
            Name = name;
            Age = age;
            AvarageGrade = averageGrade;
                

        }
    }
}
