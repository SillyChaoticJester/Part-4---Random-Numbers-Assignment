namespace Part_4___Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int diceOne, diceTwo;
            int minOne, maxOne, rangeOne;
            double rangeTwo, decimalPart, rangeTotal; 
            diceOne = generator.Next(1, 7);
            diceTwo = generator.Next(1, 7);

            //1. Random Integers

            Console.WriteLine("Please type down a minimum and maximum number for a range");
            Int32.TryParse(Console.ReadLine(), out minOne);
            Int32.TryParse(Console.ReadLine(), out maxOne);

            maxOne++;

            for (int i = 1; i <= 5; i++)
            {
                rangeOne = generator.Next(minOne, maxOne);
                Console.Write($"{rangeOne} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //2. Dice Roller

            Console.WriteLine(diceOne);
            Console.WriteLine(diceTwo);
            Console.WriteLine($"The sum of those two rolls is: {diceOne + diceTwo}");

            Console.WriteLine();
            Console.WriteLine();

            //3. Random Decimal Numbers

            for (int j = 1; j <= 3; j++)
            {
                rangeTwo = Convert.ToDouble(generator.Next(minOne, maxOne));
                decimalPart = Math.Round(generator.NextDouble(), 2);
                rangeTotal = rangeTwo + decimalPart;
                Console.Write($"{rangeTwo} ");
            }
            



        }
    }
}
