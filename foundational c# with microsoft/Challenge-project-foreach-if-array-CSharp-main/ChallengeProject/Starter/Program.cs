#region Input Variables
int examAssignments = 5;
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
#endregion

Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

foreach (string name in studentNames)
{
    #region Current Variables
    string currentStudent = name;
    int[] studentScores = new int[10];

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    #endregion

    int extraAssignments = studentScores.Length - examAssignments;
    int examScore = 0;
    int extraScore = 0;
    int extraGrade = 0;
    decimal examGrade = 0.00m;
    decimal extraCredit = 0.00m;
    decimal overallGrade = 0.00m;
    string letterGrade = "";

    int overallGradedAssignments = 0;
    foreach (int score in studentScores)
    {
        overallGradedAssignments += 1;

        if (overallGradedAssignments <= examAssignments)
            examScore += score;
        else
            extraScore += score;
    }

    examGrade = (decimal)examScore / examAssignments;
    extraGrade = extraScore / extraAssignments;
    extraCredit = (decimal)extraScore / examAssignments * 0.1m;
    overallGrade = examGrade + extraCredit;

    #region Letter Grade
    if (overallGrade >= 97)
        letterGrade = "A+";
    else if (overallGrade >= 93)
        letterGrade = "A";
    else if (overallGrade >= 90)
        letterGrade = "A-";
    else if (overallGrade >= 87)
        letterGrade = "B+";
    else if (overallGrade >= 83)
        letterGrade = "B";
    else if (overallGrade >= 80)
        letterGrade = "B-";
    else if (overallGrade >= 77)
        letterGrade = "C+";
    else if (overallGrade >= 73)
        letterGrade = "C";
    else if (overallGrade >= 70)
        letterGrade = "C-";
    else if (overallGrade >= 67)
        letterGrade = "D+";
    else if (overallGrade >= 63)
        letterGrade = "D";
    else if (overallGrade >= 60)
        letterGrade = "D-";
    else
        letterGrade = "F";
    #endregion

    Console.WriteLine($"{currentStudent}\t\t{examGrade:F1}\t\t{overallGrade:F2}\t{letterGrade}\t"
        + $"{extraGrade} ({extraCredit:F2} pts)");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
