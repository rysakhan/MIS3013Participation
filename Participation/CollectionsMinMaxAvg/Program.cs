using System;
using System.Collections.Generic;

namespace CollectionsMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<double> Examgrades = new List<double>();

            Console.WriteLine("How many exam grades are there >>>");
            int NumOfExams = Convert.ToInt32(Console.ReadLine());

            int[] ExamGrades = new int[NumOfExams - 1];
            int Exam = 0;

            for (int i = 0; i < NumOfExams - 1; i++)
            {
                Console.WriteLine("Enter exam grade >>>");
                 Exam = Convert.ToInt32(Console.ReadLine());

                ExamGrades[i] = new int[Exam];
            }

            Console.WriteLine(ExamGrades);

        }
    }
}
