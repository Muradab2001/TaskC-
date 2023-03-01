using System;

namespace grading_students
{
    internal class Program
    {
        class Soluion
        {
            static int[] solve(int[] grades)
            {
                int[] roundedGrades = new int[grades.Length];
                int n = grades.Length;
                for (int i = 0; i < n; i++)
                {
                    int grade = grades[i];
                    if (grade < 38)
                    {
                        roundedGrades[i] = grade;
                    }
                    else
                    {
                        int nextMultiple = ((grade / 5) + 1) * 5;
                        if (nextMultiple - grade < 3)
                        {
                            roundedGrades[i] = nextMultiple;
                        }
                        else
                        {
                            roundedGrades[i] = grade;
                        }
                    }
                }
                return roundedGrades;
            }

            static void Main(String[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] grades = new int[n];
                for (int grades_i = 0; grades_i < n; grades_i++)
                    grades[grades_i] = Convert.ToInt32(Console.ReadLine());

                int[] result = solve(grades);
                Console.WriteLine(String.Join("\n", result));
            }
        }
    }
}
