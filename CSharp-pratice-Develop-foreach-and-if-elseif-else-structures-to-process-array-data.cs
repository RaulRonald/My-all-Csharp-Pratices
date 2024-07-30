using static System.Random;
using static System.Console;
using static System.Math;

/* 
Project Overview
You are developing a student grading application that automates the calculation of each student's grades in a class. Here are the following parameters for the application:

- Create a C# console application.

- Start with four students. Each student has five exam scores.

- Each exam score is an integer value from 0 to 100, where 100 represents 100% correct answers.

- A student’s overall exam score is the average of their five exam scores.

Criteria for extra credit assignments:

- Include the extra credit scores in the student’s score array.
- Extra credit assignments are worth 10% of the exam score (when calculating the final numeric grade).
- Add the extra credit assignment scores to the student's total exam score before calculating the final numeric grade.

The application must automatically assign letter grades based on each student's calculated final score.

The application needs to output/display each student’s name and formatted grade.

The application should support adding other students and scores with minimal code impact.

You have already completed an initial version of the application. The starter code project for this guided module includes a Program.cs file that provides the following code features:

- The code declares variables used to define the student names and each student’s individual exam scores.
- The code includes variables and algorithms used to sum exam scores and calculate each student's average exam score.
- The code includes a hardcoded letter grade that the developer must apply manually.
- The code includes Console.WriteLine() statements to display the student grade report.

Your goal is to update the existing code to include the following features:

- Use arrays to store student names and task scores.

- Use a foreach statement to iterate through student names as an outer program loop.

- Use an if statement inside the outer loop to identify the current student’s name and access their task scores.

- Use a foreach statement inside the outer loop to iterate through the task score array and sum the values.

- Use an updated algorithm inside the outer loop to calculate each student’s average exam score.

- Use an if-elseif-else construct inside the outer loop to evaluate the average exam score and automatically assign a letter grade.

Integrate extra credit scores into the calculation of the student's final score and letter grade as follows:

- The code needs to detect extra credit tasks based on the number of elements in the student’s score array.
- The code needs to apply the 10% weighting factor to extra credit tasks before adding the extra credit scores to the sum of exam scores.

The following list shows the letter grade corresponding to the numeric scores:

Output

97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F

The updated application needs to produce a formatted student grade report similar to the following:

Output

Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
*/


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables - graded assignments
            int examAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            // Student names
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            // Write the Report Header to the console
            Console.WriteLine("Student\t\tGrade\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                // initialize/reset the sum of scored assignments
                int sumAssignmentScores = 0;

                // initialize/reset the calculated average of exam + extra credit scores
                decimal currentStudentGrade = 0;

                // initialize/reset a counter for the number of assignment 
                int gradedAssignments = 0;

                // loop through the scores array and complete calculations for currentStudent
                foreach (int score in studentScores)
                {
                    // increment the assignment counter
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                        // add the exam score to the sum
                        sumAssignmentScores += score;

                    else
                        // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                        sumAssignmentScores += score / 10;
                }

                currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }

            // required for running in VS Code (keeps the Output windows open to view results)
            Console.WriteLine("\n\rPress the Enter key to continue");
            Console.ReadLine();
        }
    }
}