namespace ControlStructures;

// Implementing Control Structures in C#
class Program
{
    public static void Main(string[] args)
    {

        // If Statement
        Console.WriteLine("If Statement");
        int y = 13;

        if (y > 5)
        {
            Console.WriteLine("x is greater than 5");
        }

        // If-else Statement
        Console.WriteLine("\nIf-else Statement");
        int x = 27;

        if (x % 2 == 0)
        {
            Console.WriteLine("x is even");
        }
        else
        {
            Console.WriteLine("x is odd");
        }

        // Else-if Statement
        Console.WriteLine("\nElse-if Statement");
        int studentGrade = 75;

        if (studentGrade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (studentGrade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (studentGrade >= 70)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("F");
        }

        // Switch Statement
        Console.WriteLine("\nSwitch Statement");
        char grade = 'C';

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;
            case 'B':
                Console.WriteLine("Good");
                break;
            case 'C':
                Console.WriteLine("Average");
                break;
            default:
                Console.WriteLine("Invalid category");
                break;
        }

        // For Loop
        Console.WriteLine("\nFor Loop");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Number " + i);
        }

        // While Loop
        Console.WriteLine("\nWhile Loop");

        int count = 0;

        while (count < 3)
        {
            Console.WriteLine("Count: " + count);
            count++;
        }

        // Do-while Loop
        Console.WriteLine("\nDo-while loop");
        int num = 1;

        do
        {
            Console.WriteLine("Number: " + num);
            num *= 2;
        } while (num < 10);

        // Foreach Loop
        Console.WriteLine("\nForeach Loop");
        string[] colors = { "Purple", "Green", "Brown" };

        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        // Break Statement
        Console.WriteLine("\nBreak Statement");
        for (int i = 0; i < 10; i++)
        {
            if (i == 6)
            {
                Console.WriteLine("Breaking loop at i=6");
                break;
            }
            Console.WriteLine("i = " + i);
        }

        // Continue Statement
        Console.WriteLine("\nContinue Statement");
        for (int i = 0; i <= 5; i++)
        {
            if (i == 4)
            {
                Console.WriteLine("Skipping iteration at i=4");
                continue;
            }
            Console.WriteLine("i = " + i);
        }

        // Return Statement
        Console.WriteLine("\nReturn Statement");
        int AddNumbers(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"The sum is {sum}");
            return sum;
        }

        int result = AddNumbers(3, 4);

    }
}