using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_cSharpObject
{
    public class Student : IComparable<Student>
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

        public int CompareTo(Student that)
        {
           int result = this.Name.CompareTo(that.Name);

            if(result == 0)
            {
                result = this.Age.CompareTo(that.Age);
            }
            return result;
        }
    }
}
