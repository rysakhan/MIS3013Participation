using System;
using System.Collections.Generic;

namespace CollectionsMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ExamGrades = new List<int>();

            int max = 0;
            int min = 0;
            int avg = 0;
            int sum = 0;
           

            Console.WriteLine("What is your exam grade >>>");
            int grade = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Do you have another entry? >>>>");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() == "yes")
            {
                Console.WriteLine("What is your exam grade >>>");
                grade = Convert.ToInt32(Console.ReadLine());
                ExamGrades.Add(grade);

                Console.WriteLine("Do you have another entry? >>>>");
            }

            max = ExamGrades[0];
            min = ExamGrades[0];
            for (int i = 0; i < ExamGrades.Count; i++)
            {

                if (ExamGrades[i] > max)
                    max = ExamGrades[i];
                if (ExamGrades[i] < min)
                    min = ExamGrades[i];
                sum += ExamGrades[i];

            }

            avg = sum / ExamGrades.Count;

            Console.WriteLine("The maximum is " + max);
            Console.WriteLine("The minimum is " + min);
            Console.WriteLine("The average is " + avg);

            //int[] ExamGrades = new int[NumOfExams - 1];


            ExamGrades.ForEach(Console.WriteLine);
        }
    }
}
