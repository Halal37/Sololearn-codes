// 13 Lesson

//Fill in the blanks to display Welcome to the screen when age is greater than 16.

int age = 24;

if(age > 16) 

{

   Console.WriteLine("Welcome");
}

//Which is the correct operator for equality testing?

//==

//Fill in the blanks to find the larger of two variables.

int a = 42;

int b = 88;

if(a > b)

{

   Console.WriteLine(a);

} 

else{

   Console.WriteLine(b);

}

/*
What is the output of this code?
int a = 8;
int b = ++a;
if(a > 5)
   b -= 3;
else
   b = 9;
Console.WriteLine(b);
*/

//6

//How many nested if statements can an if statement contain?

//As many as you want


// 14 Lesson

//Fill in the blanks to create a valid switch statement.
int x = 33;

switch(x) {

  case 8:

    Console.WriteLine("Value is 8");

    break;

  case 18:


    Console.WriteLine("Value is 18");

    break;

  
case 33:

    Console.WriteLine("Value is 33");

    break;

}

//Drag and drop from the options below to test the x variable with a switch statement.

switch (x) {

  case 10:

    Console.WriteLine("Ten");

    break;

  case 20:

    Console.WriteLine("Twenty");

    break;

  default:

    Console.WriteLine("No match");.

    break;

}

//What would occur if we forget to include a break statement at the end of case code?

//compile error


// 15 Lesson

//Fill in the blanks to display the value of x to the screen three times.
int x = 42;

int num = 0;

while(num < 3) {

  Console.WriteLine(x);

  num++;

}

//Fill in the blanks to increment the value of num by 2 to display only even values.
int num = 0;

while (num < 100)
{

  Console.WriteLine(num);

  num+=2;

}

//How many times will the following loop execute?

int x = 1;
while (x++ < 5)
{
    if (x % 2 == 0)
        x += 2;
}

//2

// 16 Lesson

//Drag and drop from the options below to create a general for loop:
for ( int x = 5; x < 10; x++;)
{

  Console.WriteLine(x);

}

//Fill in the blanks to print the EVEN values from 0 to 100 using a for loop:
for (int x = 0; x < 100; x+=2)

{
  Console.WriteLine(x);

}

//How many times will this loop run?
int x = 1;
for ( ; x < 7; )
{
  x+=2;
}

//3

// 17 Lesson

//Fill in the blanks to create a valid loop.
int x = 0;

do {

  Console.WriteLine(x);

  x+=2;

} while(x < 10);

/*
What is the output of this code?
int a = 2;
do {
  a+=3;
} while(a < 4);
Console.Write(a);
*/

//5

// 18 Lesson

/*What is the largest number that will be printed by this code?
for (int x = 1; x < 8; x++) {
  if (x > 5)
    break;
  Console.WriteLine(x);
}
*/

//5

//Fill in the blanks to print only even numbers.
for(int x=0; x<99; x++) {

  if(x%2 != 0)

    continue;

  Console.WriteLine(x);

}

// 19 Lesson

//The result of a&&b is true if:

//Both a and b are true

//How many && operators can be used in one if statement?

//As many as you want

/*
What is the output of this code?
int x = 5; int y = 12;
if(x>10 || y/x > 1)
  Console.Write(y-x);
else
  Console.Write(y);
*/

//7

//If a is true and b is false, what is the result of !(a&&b)?

//true

// 20 Lesson

/*
What is the value of x after this code?
int x = 5;
int y = 3;
x = (x > y) ? y : x;
*/

//3

// 21 Lesson

/*
How many times would this loop run?
do { }
while(false);
*/

//one

//Which of the following is used to take user input?

//Console.ReadLine

// 22 Lesson

//Fill in the blanks to print the value of x five times.
int x = 42;

int num = 0;

while(num < 5) {

   Console.WriteLine(x);

   num++; 

}


//Drag and drop from the options below to create a valid finite for loop.

for(int x=0;x<10;x++) {

  Console.WriteLine(x);

}

//Select the correct statements about && and || operators.

//(a && b) || c is true if c is true
// a || b is true if either a or b is true

//Fill in the blanks to calculate the sum of all whole numbers from 1 to 100.
int sum = 0;

for(int x=1;x<=100;x++) {

  sum += x;

}

Console.WriteLine(sum);

/*
What is the value of x after this code?
int x = 4; int y = 9;
x = (y%x != 0) ? y/x : y;
*/

//2


// 23 Lesson

/*
Multiple of 3


You are an elementary school teacher and explaining multiplication to students.
You are going to use multiplication by 3 as your example.
The program you are given takes N number as input. Write a program to output all numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".

Sample Input
7

Sample Output
12*45*7
*/

using System;
using System.Collections.Generic;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1; i<=number;i++){
                if(i%3==0){
                    Console.Write("*");
                }
                else{
                    Console.Write(Convert.ToString(i));
                }
            }
            
        }
    }
}