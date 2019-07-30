using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array is a structure which can hold multiple variables
            int[] luckyNumbers = { 4, 6, 8, 16, 18 }; // creating an array and the elements 

            luckyNumbers[2] = 900; //changing value in the array of the index position 

            Console.WriteLine(luckyNumbers[2]); // specifying the index of the number will return 8 

            string[] friends = new string[4]; //creating an array with no elements but the number 4 says how big we want to make the array ie 4 values. 
            friends[0] = "Jim";
            friends[1] = "Kelly";//putting the data into the arrays 



            Console.ReadLine();
        }
    }
}
