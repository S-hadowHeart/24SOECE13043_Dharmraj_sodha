using System;

class Program
{
    static void Main()
    {
        int examAssignments = 5;

        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

        int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = { 90, 95, 87, 88, 96, 96 };

        Console.Clear();
        // Header
        Console.WriteLine("{0,-15}{1,15}{2,16}{3,20}",
            "Student",
            "Exam Score",
            "Overall Grade",
            "Extra Credit");
        Console.WriteLine();

        foreach (string currentStudent in studentNames)
        {
            // pick the right scores array
            int[] scores;
            if (currentStudent == "Sophia") scores = sophiaScores;
            else if (currentStudent == "Andrew") scores = andrewScores;
            else if (currentStudent == "Emma") scores = emmaScores;
            else scores = loganScores;

            // split sums: full-value exams vs. raw extra credit
            int sumExam = 0;
            int sumExtraRaw = 0;
            int count = 0;

            foreach (int score in scores)
            {
                count++;
                if (count <= examAssignments)
                    sumExam += score;
                else
                    sumExtraRaw += score;
            }

            // compute averages and totals
            decimal examAverage = (decimal)sumExam / examAssignments;
            decimal extraCreditPts = ((decimal)sumExtraRaw / 10m) / examAssignments;
            decimal overallGrade = (sumExam + sumExtraRaw / 10m) / examAssignments;

            int extraAssignments = scores.Length - examAssignments;
            int extraRawAverage = extraAssignments > 0
                                   ? sumExtraRaw / extraAssignments
                                   : 0;

            // assign letter grade
            string letterGrade;
            if (overallGrade >= 97) letterGrade = "A+";
            else if (overallGrade >= 93) letterGrade = "A";
            else if (overallGrade >= 90) letterGrade = "A-";
            else if (overallGrade >= 87) letterGrade = "B+";
            else if (overallGrade >= 83) letterGrade = "B";
            else if (overallGrade >= 80) letterGrade = "B-";
            else if (overallGrade >= 77) letterGrade = "C+";
            else if (overallGrade >= 73) letterGrade = "C";
            else if (overallGrade >= 70) letterGrade = "C-";
            else if (overallGrade >= 67) letterGrade = "D+";
            else if (overallGrade >= 63) letterGrade = "D";
            else if (overallGrade >= 60) letterGrade = "D-";
            else letterGrade = "F";

            // print one line of the report
            Console.WriteLine(
                "{0,-15}{1,15:F1}{2,16:F2}{3,9}{4,6} ({5:F2} pts)",
                currentStudent,
                examAverage,
                overallGrade,
                letterGrade,
                extraRawAverage,
                extraCreditPts
            );
        }

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
