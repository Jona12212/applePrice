using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applePrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // price of one apple
                    const double Price = 32.50;

                    // user input of how many apples you want
                    Console.Write("Enter the number of apples you want to purchase: ");
                    int numberOfApples = Convert.ToInt32(Console.ReadLine());

                    // calculate the total price of apples
                    double totalPrice = numberOfApples * Price;

                    // To convert the total price to a whole number
                    int convertedPrice = (int)totalPrice;

                    // Display the total price and the whole number price
                    Console.WriteLine($"The total price of {numberOfApples} apples is {totalPrice}.");
                    Console.WriteLine($"The value of the converted price is {convertedPrice}");
                } 
                catch (FormatException)
                {
                    Console.WriteLine("Please enter the right input.");
                }              
                break;
            }

        

        }
    }
}

