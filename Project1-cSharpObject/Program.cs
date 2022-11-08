using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Project1_cSharpObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                                List<Student> studentList = new List<Student>()
                                {
                                    new Student(0, "Bob", 15, 'A'),
                                    new Student(0, "Charlie", 13, 'A'),
                                    new Student(0, "Bob", 18, 'A'),
                                    new Student(0, "Ashly", 12, 'A')

                                };
                                studentList.Sort();


                                Student student2 = new Student(0, "Chris", 16, 'C');
                                
                                int index = studentList.BinarySearch(student2);

                                if(index < 0)
                                {
                                    studentList.Insert(~index, student2);
                                }


                                foreach (Student student in studentList)
                                {
                                    Console.WriteLine($"Name:  {student.Name}  Age:  {student.Age}");
                                }
                    


            }
                catch(ArgumentException ae)
                {
                        Console.WriteLine(ae.Message);
               
                }
                finally
                {
                        Console.WriteLine("Press enter to quit program");
                        Console.ReadLine();
                }

         
        }



        public static class StringToInteger
        {
            public static int StringToInt(string numAsString)
            {
                return int.Parse(numAsString);
            }
        }





    }
}
