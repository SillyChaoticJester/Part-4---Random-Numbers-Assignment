namespace Part_4___Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int diceOne, diceTwo;
            int minOne;
            int maxOne;
            int rangeOne; 
            diceOne = generator.Next(1, 7);
            diceTwo = generator.Next(1, 7);

            //1. Random Integers

            //I know it's a mess right now, but I can fix it if I figure out how loops work with integers and random number generators

            Console.WriteLine("Please type down a minimum and maximum number for each range");
            minOne = Convert.ToInt32(Console.ReadLine());
            maxOne = Convert.ToInt32(Console.ReadLine()) + 1;
   

            rangeOne = generator.Next(minOne, maxOne);


            Console.Write($"{rangeOne} ");


            Console.WriteLine();
            Console.WriteLine();

            //2. Dice Roller

            Console.WriteLine(diceOne);
            Console.WriteLine(diceTwo);
            Console.WriteLine($"The sum of those two rolls is: {diceOne + diceTwo}");

            Console.WriteLine();
            Console.WriteLine();

            //3. Random Decimal Numbers





        }
    }
}
