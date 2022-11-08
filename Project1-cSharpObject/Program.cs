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
                                List<string> groceryList = new List<string>()
                                {
                                    "Banana",
                                    "Oranges",
                                    "Apples"

                                };
                groceryList.Add("Potato Chips");
                groceryList.RemoveAt(0);
                groceryList.Insert(0, "Chocolate");
                              
                                foreach (string item in groceryList)
                                {
                                    Console.WriteLine(item);
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
