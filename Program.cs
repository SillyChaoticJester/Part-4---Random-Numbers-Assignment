namespace Part_4___Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int diceOne, diceTwo;
            int minOne, minTwo, minThree, minFour, minFive;
            int maxOne, maxTwo, maxThree, maxFour, maxFive;
            diceOne = generator.Next(1, 7);
            diceTwo = generator.Next(1, 7);

            //1. Random Integers

            Console.WriteLine("Please type down a minimum and maximum number for each range");

            //2. Dice Roller

            Console.WriteLine(diceOne);
            Console.WriteLine(diceTwo);
            Console.WriteLine($"The sum of those two rolls is: {diceOne + diceTwo}");

            //3. Random Decimal Numbers
        }
    }
}
