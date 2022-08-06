// 1 Lesson

//C# applications run:

//on the .NET Framework

//Which one is NOT part of the .NET Framework?

//Operation System

// 2 Lesson

//Which is a valid C# variable name?

//Bad_Var

//Fill in the blanks to declare a variable named num of type integer and assign 42 to it.

int num;

num = 42;

//Drag and drop the correct data types from the options below.
bool a = false;

double b = 4.22;

string c = "Hi";

int d = 11;

// 3 Lesson

//What is the name of the IDE used to create C# programs?

//Visual Studio

//Every console application in C# should contain:

//Main method

//Which type of application uses a text-only interface?

//Console Application

// 4 Lesson

//Drag and drop from the options below to display "Learning C#".

Console.WriteLine("Learning C#");

/*
What is the output of this code?
int a = 4;
int b = 2;
Console.Write(a);
Console.Write(b);
*/

//42

// 5 Lesson

//Drag and drop from the options below to take user input and store it in the temp variable:
string temp;

temp = Console.ReadLine();

//Drag and drop from the options below to make the following program work:
double n;

string x = "77";

n = Convert.ToDouble(x);

// 6 Lesson

/*
What is the output of this code?
int x = 8;
// x = 3;
Console.WriteLine(x);
*/

//8

//Fill in the blanks to make the text a comment.
/*
 Declaring an integer

  and printing it 
*/


int x = 42;

Console.WriteLine(x);

// 7 Lesson

//What is the type of the temp variable?
//var temp = 14.55;

//Double

/*
What is the output of this code?
var n1;
n1 = true;
Console.WriteLine(n1);
*/

//error

// 8 Lesson

//Fill in the blank to make the variable num a constant.

const int num=2;

// 9 Lesson

//Fill in the blanks to display the result of the multiplication of x and y.
int x = 42;

int y = 7;

int z = x*y;

Console.WriteLine(z);

/*
What is the output of this code?
int x = 16;
int y = 5;
Console.WriteLine(x/y);
*/

//3

//Which operator is used to determine the remainder?

//%

//Fill in the missing parentheses to have x equal 15.
int x = (2 + 3)* 3;

Console.WriteLine(x);


// 10 Lesson

//What is the alternative for x = x + 5?

//x += 5;

//Fill in the missing part of the following code to divide x by 3 using the shorthand division operator.
int x = 42;

x /= 3;

/*
What is the output of this code?
int x = 6;
x++;
Console.WriteLine(x);
*/

//7

//What's the difference between ++x and x++?
//Select All That Apply

//x++ uses x's value then increments it
//++x increments x's value before using it

//Fill in the missing operator to decrease the value of x by one.
int x = 42;

x--;

Console.WriteLine(x);


// 11 Lesson

//Rearrange the code to create a valid program.

static void Main(string[] args){
	string msg = "Hello";
	Console.WriteLine(msg);
}

//Drag and drop from the options below to display the value of x to the screen.
static void Main(string[] args)

{

   int x = (4 + 3) * 2;
   
   Console.WriteLine(x);

}

/*
What is the output of this code?
int a = 4;
int b = 6;
b = a++;
Console.WriteLine(++b);
*/

//5

//Fill in the blanks to declare two variables of type int and display their sum to the screen.
int x = 8;

int y = 15;

Console.WriteLine(x+y);

/*
What is the output of this code?
int x = 15;
int y = 6;
x %= y;
Console.WriteLine(x);
*/

//3


// 12 Lesson

/*

Area of a Circle


We are going to write a program that will calculate the area of ​​a circle.
The area enclosed by a circle of radius r is πr², where π (pi) is the constant ratio of the circumference of any circle to its diameter, and r is the radius.
The given program declares a constant pi variable with a value of 3.14.
Complete the program to take the radius as input, then calculate and output the area of the circle.

Sample Input
5

Sample Output
78.5

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            radius=Convert.ToDouble(Console.ReadLine());
            var result = radius*radius*pi;
            Console.WriteLine(result);
            
        }
    }
}