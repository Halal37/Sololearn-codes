// 42 Lesson

//Fill in the blanks to instantiate an array of 42 elements of type double:

double[ ] a = new double[42];

//The third element of an array has index:

//2

//Fill in the blanks to instantiate the array with initial values:

int[ ] a = {1, 2, 3};

/*
What is the value of x after these statements execute?
int[ ] a = {4, 7, 2};
int x = a[0]+a[2];
*/

//6

// 43 Lesson

//Fill in the blanks to print all elements of the array using a for loop.
int[ ] arr = new int[7];

for
(int k=0;k<7;k++) {

  Console.WriteLine(arr[k]);

}

//Fill in the blanks to create a valid foreach loop that displays all even elements of the array.

int[ ] nums = {5, 2, 3, 4, 7};

foreach(var n in nums) {

  if(n%2 == 0)

    Console.WriteLine(n);

}

/*
What is the output of this code?
int[ ] arr = {8, 2, 6};
int y=0;
foreach (int x in arr) {
  y+=x/2;
}
Console.Write(y);
*/

//8

// 44 Lesson

//Fill in the blanks to declare a two-dimensional array of integers with 8 rows and 8 columns.

int[ , ] chessBoard = new int[8, 8];

//How many dimensions does the following array have?
//int[ , , , ] arr;

//4

// 45 Lesson

//Fill in the blanks to declare a jagged array that contains 8 two-dimensional arrays.

int[ ][,] a = new int[8][,];

// 46 Lesson

/*
What is the output of this code?
int[ , , ] a = new int[2, 3, 4];
Console.Write(a.Rank);
*/

//3

/*
What is the output of this code?
int[ ] a = {4, 6, 5, 2};
int x = a[0]+a.Min();
Console.Write(x);
*/

//6


// 47 Lesson

/*
What is the output of this code?
string s = "SoloLearn is awesome";
Console.Write(s.IndexOf('e'));
*/

//5

//Fill in the blanks to assign the last character of the string to the x variable:

string s = "Hello";

char x;

x = s[s.Length-1];

// 48 Lesson

//An array is a:

//reference type

//Fill in the blanks to print all elements of the array.

int[] arr = {0, 5, 3, 2, 1 };

foreach (int item in arr) {

  Console.WriteLine(item);

}

/*
What is the output of this code?
string s = "SoloLearn";
Console.Write(s[6]);
*/

//a

//How many elements can the following array store?
//int[ , , ] array = new int[4, 5, 3];

//60

/*
What is the output of this code?
string s = "SoloLearn";
int x = s.Length;
int y = s.IndexOf("e");
Console.Write(x%y);
*/

//4


// 49 Lesson

/*
Words

The program you are given defines an array with 10 words and takes a letter as input.
Write a program to iterate through the array and output words containing the taken letter.
If there is no such word, the program should output "No match".

Sample Input
u

Sample Output
fun
*/

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;
            foreach(var word in words){
                if(word.Contains(letter)){
                    Console.WriteLine(word);
                    count++;
                }
                
            }
                if (count==0)
                Console.WriteLine("No match");
            
        }
    }
}
