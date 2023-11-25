//string[] fraudulent = new string[3];

/* fraudulent[0] = "1234";
fraudulent[1] = "2345";
fraudulent[2] = "3456"; */

// string[] fraudulent = {"12304", "2345", "3456"};
// Console.WriteLine($"Fraudulent Order ID: {fraudulent[0]}");

// fraudulent[0] = "0000";
// Console.WriteLine($"Reasigned Fraudulent Order ID: {fraudulent[0]}");
// Console.WriteLine($"There are {fraudulent.Length} order IDs processed.");




// int[] inventory = { 100, 200, 30, 50, 90 };
// int sum = 0;
// int bin = 0;
// foreach(int item in inventory){
//     sum += item;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {item} items | Running total = {sum}");
// }
// Console.WriteLine($"we have {sum} items in the inventory");




// string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach( string orderID in fraudulentOrderIDs){
//     if(orderID.StartsWith("B")){
//         Console.WriteLine(orderID);
//     }
// }




//GRADE SYSTEM TASK
using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };   

string[] studentNames = new string[] { "sophia", "andrew", "emma", "logan", "becky", "chris", "eric", "gregor" };
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

//Write the Report header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string student in studentNames)
{
    string currentStudent = student;

    if (currentStudent == "sophia")
        studentScores = sophiaScores;
    else if(currentStudent == "andrew")
        studentScores = andrewScores;
    else if(currentStudent == "emma" )
        studentScores = emmaScores;
    else if(currentStudent == "logan")
        studentScores = loganScores;
    else if(currentStudent == "becky" )
        studentScores = beckyScores;
        else if(currentStudent == "chris")
        studentScores = chrisScores;
    else if(currentStudent == "eric" )
        studentScores = ericScores;
    else if(currentStudent == "gregor")
        studentScores = gregorScores;
    else
        continue;


    // initialize/reset the sum of scored assignments
    int sumAssignmentScore = 0;
    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;
    //initialize or reset a counter for the number of assignments
    int gradedAssignments = 0; 
    

    foreach (int score in studentScores)
    {
    // increment assignment counter
    gradedAssignments += 1;

    if ( gradedAssignments <= examAssignments)
        sumAssignmentScore += score;
    else
    // add the extra credit points to the sum - bonus points equal to 10% of an exam score
        sumAssignmentScore += score / 10;
    }

    currentStudentGrade = (decimal)sumAssignmentScore / examAssignments;

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

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}");
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
