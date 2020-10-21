using System;

public class ComputeFactorialRemainder
{
    public static void Main()
    {
        ComputeFactorialRemainder obj = new ComputeFactorialRemainder();

        Console.WriteLine("Enter input:");
        int n = Convert.ToInt32(Console.ReadLine());

        int output = obj.factorialRemainder(n);
        Console.WriteLine("Output: {0}", output);
    }

    public int factorialRemainder(int n)
    {
        // Count of numbers for which required condition is satisfied
        int count = 0;

        for (int x = 1; x <= n; x++)
        {
            int factorial = calculateFactorial(x - 1);

            if (factorial % x == (x - 1))
                count++;
        }

        return count;
    }

    public int calculateFactorial(int number)
    {
        int fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact = fact * i;
        }

        return fact;
    }
}
