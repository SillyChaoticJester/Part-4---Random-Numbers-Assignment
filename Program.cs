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
            int rangeOne, rangeTwo, rangeThree, rangeFour, rangeFive;
            diceOne = generator.Next(1, 7);
            diceTwo = generator.Next(1, 7);

            //1. Random Integers

            Console.WriteLine("Please type down a minimum and maximum number for each range");
            Console.WriteLine("Range One:");
            minOne = Convert.ToInt32(Console.ReadLine());
            maxOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Range Two:");
            minTwo = Convert.ToInt32(Console.ReadLine());
            maxTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Range Three:");
            minThree = Convert.ToInt32(Console.ReadLine());
            maxThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Range Four:");
            minFour = Convert.ToInt32(Console.ReadLine());
            maxFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Range Five:");
            minFive = Convert.ToInt32(Console.ReadLine());
            maxFive = Convert.ToInt32(Console.ReadLine());

            rangeOne = generator.Next(minOne, maxOne);
            rangeTwo = generator.Next(minTwo, maxTwo);
            rangeThree = generator.Next(minThree, maxThree);
            rangeFour = generator.Next(minFour, maxFour);
            rangeFive = generator.Next(minFive, maxFive);

            Console.WriteLine(rangeOne);
            Console.WriteLine(rangeTwo);
            Console.WriteLine(rangeThree);
            Console.WriteLine(rangeFour);
            Console.WriteLine(rangeFive);

            //2. Dice Roller

            Console.WriteLine(diceOne);
            Console.WriteLine(diceTwo);
            Console.WriteLine($"The sum of those two rolls is: {diceOne + diceTwo}");

            //3. Random Decimal Numbers
        }
    }
}
