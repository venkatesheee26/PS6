using System;

class Program
{
    static void Main()
    {
        // Create jagged array for student scores
        int[][] studentScores = new int[3][]
        {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
        };

        // Print scores of each student
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write($"Student {i + 1} scores: ");

            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write(studentScores[i][j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        // Calculate average score for each student and print the results
        for (int i = 0; i < studentScores.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < studentScores[i].Length; j++)
            {
                sum += studentScores[i][j];
            }

            double average = (double)sum / studentScores[i].Length;
            Console.WriteLine($"Average score for student {i + 1}: {average:F2}");
        }

        Console.WriteLine();

        // Calculate average score for all students combined and print the result
        int totalSum = 0;
        int totalElements = 0;

        for (int i = 0; i < studentScores.Length; i++)
        {
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                totalSum += studentScores[i][j];
                totalElements++;
            }
        }

        double totalAverage = (double)totalSum / totalElements;
        Console.WriteLine($"Average score for all students: {totalAverage:F2}");
    }
}
