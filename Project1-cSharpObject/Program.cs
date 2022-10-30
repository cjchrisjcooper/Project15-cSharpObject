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
                        Map map1 = new Map(10, 10);
                        Path path = new Path( new MapLocation[10]
                        {
                                new MapLocation(0,5 , map1),
                                new MapLocation(1,5 , map1),
                                new MapLocation(2,5 , map1),
                                new MapLocation(3,5 , map1),
                                new MapLocation(4,5 , map1),
                                new MapLocation(5,5 , map1),
                                new MapLocation(6,5 , map1),
                                new MapLocation(7,5 , map1),
                                new MapLocation(8,5 , map1),
                                new MapLocation(9,5 , map1),
                        });

                        List<MapLocation> oldList = new List<MapLocation>()
                        {
                                new MapLocation(0,5 , map1),
                                new MapLocation(1,5 , map1),
                                new MapLocation(2,5 , map1),
                                new MapLocation(3,5 , map1),
                                new MapLocation(4,5 , map1),
                                new MapLocation(5,5 , map1),
                                new MapLocation(6,5 , map1),
                                new MapLocation(7,5 , map1),
                                new MapLocation(8,5 , map1),
                                new MapLocation(9,5 , map1),
                        };
                //Added an extra comment to the repo
                //Added an extra comment to the repo
                //Console.WriteLine(StringToInteger.StringToInt("15"));


                var newList = oldList.Where(map => map.X == 7).FirstOrDefault();


                //foreach(var location in newList)
                //{
                //Console.WriteLine(location.X + ", " + location.Y);
                //}

                    Console.WriteLine(newList.X + ", " + newList.Y);
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
