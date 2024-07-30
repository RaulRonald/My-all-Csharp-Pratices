using System;

/*
You are developing a Student GPA Calculator that will help calculate students' overall grade point average. The parameters for the application are as follows:

You receive the student's name and course information.
Each course has a name, the student's grade, and the number of credit hours for the course.
The application needs to perform basic mathematical operations to calculate the specified student's GPA.
The application needs to output/display the student's name, course information, and GPA.
To calculate the GPA, do the following:

Multiply the grade value of a course by the number of credit hours for that course.
Do this for each course and add these results together.
Divide the resulting sum by the total number of credit hours.
You will receive the following example of course information and GPA for a student:

Student: Sophia Johnson

Course	Grade	Credit Hours
English 101	4	3
Algebra 101	3	3
Biology 101	3	4
Computer Science I	3	4
Psychology 101	4	3
Final GPA: 3.35
 */

// initialize variables

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

//credits and name

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

//calculating points

int totalCreditHours = 0;

totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;

totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;

int firstDigit = (int)(gradePointAverage * 10) % 10;

int secondDigit = (int)(gradePointAverage * 100) % 10;

//printing

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

