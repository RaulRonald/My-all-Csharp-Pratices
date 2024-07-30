using System;

/*
You are developing a Student Grades application that automates the calculation of the current grades for each student in a class. The parameters of the application are as follows:

You receive a small list of four students with the grades from the five assignments they completed.
Each grade is expressed as an integer value from 0 to 100, where 100 represents 100% accuracy.
The final score is calculated as the average of the five assignment grades.
The application needs to perform basic mathematical operations to compute the final grades for each student.
Your application needs to output/display the name and final score of each student.
Currently, the teacher's grade book shows each student's graded assignments as follows:

Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah: 84, 96, 73, 85, 79

Jeong: 90, 92, 98, 100, 97

The teacher requires the calculated grades for each student to be displayed as follows:

Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A

Additional Context
Grading Scale: Ensure you have a clear grading scale to determine letter grades from numerical averages.
Application Output: Make sure the application properly formats the output to match the required display format.
Feel free to ask if you need further clarification or additional context for this problem!
 */

// initialize variables - graded assignments 

//number of grades per student

int currentAssignments = 5;

//grades

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

//sum of the students grades

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

//printing

Console.WriteLine("sum of grades :");
Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);

//average of the grades

decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("grade average :");
Console.WriteLine("Sophia: " + sophiaScore + " A");
Console.WriteLine("Nicolas: " + nicolasScore + " B");
Console.WriteLine("Zahirah: " + zahirahScore + " B");
Console.WriteLine("Jeong: " + jeongScore + " A");