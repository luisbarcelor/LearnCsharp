class Program
{
    static void Main(string[] args)
    {
        int currentAssignments = 5;

        int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 }; 

        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

        Console.WriteLine("Student\t\tExam Score\tOverall\t\tGrade\t\tExtra Credit\n");

        foreach (string name in studentNames)
        {
            string currentStudent = name;
            int[] currentStudentScores;

            if (currentStudent == "Sophia")
                currentStudentScores = sophiaScores;
            
            else if (currentStudent == "Andrew")
                currentStudentScores = andrewScores;
            
            else if (currentStudent == "Emma")
                currentStudentScores = emmaScores;
            
            else if (currentStudent == "Logan")
                currentStudentScores = loganScores;
            
            else if (currentStudent == "Becky")
                currentStudentScores = beckyScores;
            
            else if (currentStudent == "Chris")
                currentStudentScores = chrisScores;
            
            else if (currentStudent == "Eric")
                currentStudentScores = ericScores;
            
            else if (currentStudent == "Gregor")
                currentStudentScores = gregorScores;
            
            else
                continue;
            
            
            int scoreCount = 0;
            int extraScoreCount = 0;
            decimal currentStudentExamScore = 0m;
            decimal currentStudentExtraScore = 0m;
            decimal currentStudentExtraScorePercentage = 0m;
            int currentStudentExtraScoreAverage = 0;

            foreach (decimal score in currentStudentScores)
            {
                scoreCount++;

                if (scoreCount > currentAssignments)
                {
                    extraScoreCount++;
                    
                    currentStudentExtraScore += score;
                    currentStudentExtraScorePercentage += score * 0.10m / currentAssignments;
                }
                else
                {
                    currentStudentExamScore += score / currentAssignments;
                }
            }
            
            if (extraScoreCount > 0)
                currentStudentExtraScoreAverage = (int)(currentStudentExtraScore / extraScoreCount);
            
            
            decimal currentStudentOverall = currentStudentExamScore + currentStudentExtraScorePercentage;

            if (currentStudentOverall > 100)
                currentStudentOverall = 100;
            
            
            string currentStudentLetterGrade;
            
            if (currentStudentOverall >= 97)
                currentStudentLetterGrade = "A+";
            
            else if (currentStudentOverall >= 93)
                currentStudentLetterGrade = "A";
            
            else if (currentStudentOverall >= 90)
                currentStudentLetterGrade = "A-";
            
            else if (currentStudentOverall >= 87)
                currentStudentLetterGrade = "B+";
            
            else if (currentStudentOverall >= 83)
                currentStudentLetterGrade = "B";
            
            else if (currentStudentOverall >= 80)
                currentStudentLetterGrade = "B-";
            
            else if (currentStudentOverall >= 77)
                currentStudentLetterGrade = "C+";
            
            else if (currentStudentOverall >= 73)
                currentStudentLetterGrade = "C";
            
            else if (currentStudentOverall >= 70)
                currentStudentLetterGrade = "C-";
            
            else if (currentStudentOverall >= 67)
                currentStudentLetterGrade = "D+";
            
            else if (currentStudentOverall >= 63)
                currentStudentLetterGrade = "D";
            
            else if (currentStudentOverall >= 60)
                currentStudentLetterGrade = "D-";
            
            else
                currentStudentLetterGrade = "F";
            

            Console.WriteLine($"{currentStudent}:\t\t{currentStudentExamScore}\t\t{currentStudentOverall}\t\t" +
                              $"{currentStudentLetterGrade}\t\t{currentStudentExtraScoreAverage} ({currentStudentExtraScorePercentage} pts)");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

    }
}

