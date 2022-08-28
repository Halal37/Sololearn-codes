// 68 Lesson

//Which of the following statements are true?

//You cannot derive from a struct

//Fill in the blanks to declare a struct.

public struct Car {

  public string brand;  

  public double price;

}

// 69 Lesson

/*
What is the output of this code?
enum Test { a=2, b, c, d, e }; 
static void Main(string[] args) {
  int x = (int)Test.c;
  Console.WriteLine(x);
}
*/

//4

//Drag and drop from the options below to create an Enum called Color, with the values RED, BLUE, GREEN.

enum Color  {

  RED, BLUE, GREEN

}

// 70 Lesson

/*
What is the maximum index of the following array?
int[] arr = new int[] { 4, 5, 8 };
*/

//2

//Fill in the blanks to handle all possible exceptions.

int x = 12;

int y = 0;

try {

  int z = x / y;

  Console.WriteLine(z);

}

catch (Exception e) {

  Console.WriteLine("Error");

}

/*
What is the value of x after this code?
int[] arr = {2, 5, 3};
int x = 0;
try {
  x = arr[5];
}
catch (Exception e) {
  x = arr[x];
}
*/

//2

//Which class should you use to handle all possible exceptions?

//Exception

// 71 Lesson

//The File class belongs to which namespace?

//System.IO

//Drag and drop from the options below to check if the file "names.txt" exists. If it does, add "David" to the end of the file.

if (File.Exists("names.txt")) {

  File.AppendAllText("names.txt", "David");

}

// 72 Lesson

//Can you inherit from a struct?

//No

/*
What is the output of this code?
enum Test { A, B, C=5, D }; 
static void Main(string[] args) {
  int x = (int)Test.D;
  Console.WriteLine(x);
}
*/

//6

//int is a Struct.

//True

/*
Which of the following is the correct way to define a variable of the struct Person declared below?
struct Person {
  private string name; 
  private int age; 
}
*/

//Person p;

/*
What is the value of x after this code?
int x = 0;
try {
  x /= x;
  x += 1;
}
catch (Exception e) {
  x += 3;
 }
finally {
  x += 4;
}
*/

//7

//Fill in the blanks to handle exceptions.
int x = 0;

try {

  x = Convert.ToInt32("AAA");

}

catch (Exception e) {

  Console.WriteLine("Error");

}

// 73 Lesson

/*
Robot-barman


You have a robot-barman and his goal is to neatly arrange drinks on the shelves of the bar. He is very smart and takes as many drinks as are necessary to evenly distribute them on the shelves, but he still has problems with division.

The program installed in the robot takes the number of drinks and the number of the shelves as input.
Complete the program to evenly distribute the drinks on shelves: by dividing the number of drinks by the number of shelves and outputting the result.
The program must also, handle those two possible problems:
1. the divider (the number of shelves) should never be zero
2. both inputs should be integers.
For the first exception, the program should output "At least 1 shelf" and for the second, "Please insert an integer".

Sample Input
6
two

Sample Output
Please insert an integer
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
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());

                int result = drinks / shelves;
                Console.WriteLine(result);

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("At least 1 shelf");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Please insert an integer");

            }
        }
    }
}