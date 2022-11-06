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
