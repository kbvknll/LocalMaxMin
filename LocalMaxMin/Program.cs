using System;

class Program
{
    static void Main()
    {
        int days = Convert.ToInt32(Console.ReadLine());

        int[] temperatures = new int[days];
        for (int i = 0; i < days; i++)
        {
            temperatures[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i < days - 1; i++)
        {
            if (temperatures[i] > temperatures[i - 1] && temperatures[i] > temperatures[i + 1])
            {
                Console.WriteLine($"day {i + 1}: {temperatures[i]} (max)");
            }
            else if (temperatures[i] < temperatures[i - 1] && temperatures[i] < temperatures[i + 1])
            {
                Console.WriteLine($"day {i + 1}: {temperatures[i]} (min)");
            }
        }
    }
}
