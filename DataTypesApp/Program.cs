using System;

namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main()
        {

            Console.Write("Enter the pieces of apple: ");
            int piecesOfApple = int.Parse(Console.ReadLine());

            Console.Write("Enter the total price of the apple(s): ");
            double totalPrice = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total Price for {piecesOfApple} pieces of apple(s): ${totalPrice}");
            int convertedPrice = (int)totalPrice;

            
            Console.WriteLine($"Original Price: ${totalPrice}");
            Console.WriteLine($"Converted Price (Whole Number): ${convertedPrice}");

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}