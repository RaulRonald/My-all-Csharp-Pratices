using static System.Random;
using static System.Console;
using static System.Math;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //"matrix of characters"

            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            //traverse matrix

            int pos = 0;
            foreach (string valor in fraudulentOrderIDs)
            {

                //printing

                Console.WriteLine($"{pos} : {valor}");
                pos++;
            }

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            //creating array of string

            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            //traverse array

            foreach (string orderID in orderIDs)
            {
                
                //if the first char is B print this value

                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }

        }
    }
}