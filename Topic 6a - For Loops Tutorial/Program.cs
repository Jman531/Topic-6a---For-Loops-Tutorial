namespace Topic_6a___For_Loops_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfNumbers, factorialOfNumber, evenNumberAmount, num;

            num = 0;
            sumOfNumbers = 0;
            evenNumberAmount = 0;
            factorialOfNumber = 1;

            Console.WriteLine("Numbers 1 to 10:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("All multiples of fives from 5 to 50:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write((i * 5) + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Numbers from 99 to 55 in descending order:");

            for (int i = 99; i >= 55; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The sum of the numbers from 20 to 40:");

            for (int i = 20; i <= 40; i++)
            {
                sumOfNumbers += i;
            }

            Console.WriteLine(sumOfNumbers);

            Console.WriteLine();

            Console.WriteLine("Even numbers only now:");

            sumOfNumbers = 0;

            for (int i = 20; i <= 40; i++)
            {
                if ((i % 2) == 0)
                {
                    sumOfNumbers += i;
                }
            }

            Console.WriteLine(sumOfNumbers);

            Console.WriteLine();

            Console.WriteLine("Odd numbers only now:");

            sumOfNumbers = 0;

            for (int i = 20; i <= 40; i++)
            {
                if ((i % 2) > 0)
                {
                    sumOfNumbers += i;
                }
            }

            Console.WriteLine(sumOfNumbers);

            Console.WriteLine();

            Console.WriteLine("Five factorial is:");

            for (int i = 1; i <= 5; i++)
            {
                factorialOfNumber = factorialOfNumber * i;
            }

            Console.WriteLine(factorialOfNumber);

            Console.WriteLine();

            Console.WriteLine("Give me 10 numbers and I will count how many are even:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("What is #" + i + ": ");
                num = Convert.ToInt32(Console.ReadLine());

                if ((num % 2) == 0)
                {
                    evenNumberAmount++;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Out of the 10 you gave me " + evenNumberAmount + " of them are even!");
        }
    }
}
