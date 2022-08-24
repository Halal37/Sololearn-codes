// 24 Lesson
 
//Every C# program starts with the method:

//Main

//If you do not want your method to return a value, you should use the return type:

//void

//Fill in the blanks to declare a method that does not return a value and displays "Welcome" to the screen:
static void Greet()

{

  Console.WriteLine("Welcome");

}

//Drag and drop from the options below to declare a valid method and call it in Main:
 
static void Func() 

{

  Console.Write("test");

}

static void Main(string[] args)

{
	
  Func();
  
}


// 25 Lesson

//Fill in the blanks to declare a method that takes one integer parameter and then displays the value divided by 2.

void MyFunc(int x) 

{

  int result = x/2;

  Console.WriteLine(result);

}

//Fill in the blanks to declare a method and call it from Main with the argument 88:

static void func(int x) 

{

  Console.WriteLine(x/2);

}

static void Main(string[] args)

{

  func(88);

}

//How many times can you call a method with different arguments?

//As many as you want

// 26 Lesson

//Fill in the missing parts of the following code to define a method that returns an int value and has two parameters.

int Test(int a, int b)

{

 // some code

}

//Fill in the blanks to declare a method, which returns the largest value of its parameters:

int Max(int a, int b)

{

  if(a > b)

    return a;

  else

    return b;

}


// 27 Lesson

/*
What is the output of this code?
static int Vol(int x, int y=3, int z=1) {
  return x*y*z;
}
static void Main(string[] args) {
  Console.WriteLine(Vol(2, 4));
}
*/

//8

//Call the method using named arguments with the values 5 for "from", 99 for "to" and 2 for "step":

static int calc(int from, int to, int step=1) {

  int res=0;

  for(int i=from;i<to;i+=step) {

    res += i;

  }

  return res;

}

static void Main(string[] args)

{

  int res = calc(step:2, to:99, from:5);

  Console.WriteLine(res);

}


// 28 Lesson

/*
What is the output of this code?
static void Test(int x) {
  x = 8;
}
static void Main() {
  int a = 5;
  Test(a);
  Console.WriteLine(a); 
}
*/

//5

//Fill in the blanks to create a method that swaps the values of its two arguments.

void Swap(ref int x, ref int y)

{

  int temp;

  temp = x;

  x = y;

  y = temp;

}

//Fill in the blanks to ask for user input in the method and return the value entered using output parameters.

static void Ask(out string name)

{

  
name = Console.ReadLine();

}

static void Main(string[] args)

{

  string nm;

  Ask(out nm);

}


// 29 Lesson

//Method overloading means:

//Same method name, different parameters


/*
What is the output of this code?
static void Print(int a) {
  Console.WriteLine(a*a);
}
static void Print(double a) {
  Console.WriteLine(a+a);
}
static void Main(string[] args) {
  Print(3);
}
*/

//9

// 30 Lesson

//What is the factorial of 5?

//120

//What prevents the recursive method to call itself forever?

//the exit condition

// 31 Lesson

//How many loops can you nest within each other?

//Any

// 32 Lesson

//Every C# program has the method:

//Main

//Fill in the blanks to create a method that calculates and returns the sum of its parameters.

int Calc(int a, int b) {

  return a+b;

}

//Fill in the blanks to declare a method that has two int parameters with default values 6 and 8, respectively, and displays their product to the screen. Call the method in Main using named arguments.

static void Test(int x=6, int y=8) {

  Console.WriteLine(x*y);

} 

static void Main(string[] args)

{

  Test(x:7, y:11);

}

//If a method does not return any value, you should use the return type:

//void

/*
What is the output of this code?
static int Test(out int x, int y=4) {
  x = 6;
  return x * y;
}
static void Main(string[] args) {
  int a;
  int z = Test(out a);
  Console.WriteLine(a + z);
}
*/

//30


// 33 Lesson

/*
Level Points


Passing the first level of a video game awards the player 1 point. For each subsequent level passed, the points awarded increment by 1 (2 for the 2nd level, 3 for the 3rd, and so on).
The program you are given takes the number of passed levels as input. Complete the given function to take that number as an argument, and recursively calculate and return the total number of points given for all passed levels.

Sample Input
3

Sample Output
6

Explanation
Level 1: 1 point
Level 2: 2 points
Level 3: 3 points
Total: 1+2+3 = 6 points.
*/

using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        
        static int Points(int levels)
        {
            if(levels==1){
                return 1;
            }
            else{
                return levels+Points(levels-1);
            }
            

        }

    }

}