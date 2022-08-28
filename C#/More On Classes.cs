// 50 Lesson

//Drag and drop from the options below to declare a destructor for class Person.

class Person {

   ~Person(){

  }

}

//Destructors are:

//invoked when an object is deleted

// 51 Lesson

//Drag and drop from the options below to have a valid Main method:
 

static void Main(string[] args)

//Drag and drop from the options below to assign the value of the Math class static PI variable to x.

double x = Math.PI;

//To be able to directly call a method in Main, it should be:

//static

//Drag and drop from the options below to initialize the static Age property of the Person class using a static constructor:

class Person {

  public static int Age { get; set; }

  static Person() {

    Age = 0;

  }

}

// 52 Lesson

//A static class contains:

//only static members

/*
What is the output of this code?
int[] arr = { 9, 4, 10, 42 };
Array.Sort(arr);
double x = Math.Sqrt(arr[1]);
Console.WriteLine(x);
*/

//3

// 53 Lesson

//Fill in the blanks to print the age variable of the Person class using the this keyword.

class Person {

  private int age;

  public void Print() {

    Console.Write(this.age);

  }

}

//Which statements are true?
//Select All That Apply

//constants should be assigned a value when declared
//readonly fields can be initialized by the constructor

// 54 Lesson

/*
What is the output of this code?
string str = "I know C#";
char x = str[3];
Console.WriteLine(x);
*/

//n

//Fill in the blanks to define a valid indexer:

class Person {

  private string name;

  public char this[int index] {

    get {

      return name[index];

    }

  }

}


// 55 Lesson

//Operator overloading means:

//defining custom actions for operators

//Fill in the blanks to overload the greater than operator for the Box class.

public static bool operator>(Box a,Box b) {

  if (a.Height*a.Width > b.Height*b.Width)

    return true;

  else

    return false;

}


// 56 Lesson

//Fill in the blanks to declare a destructor for the class Book.

class Book {

  ~Book() {

    //some code

  }

}

/*
What is the output of this code?
class Temp {
  public int num = 2;
  public Temp() { num++;}
  ~Temp() { num++; }
}
static void Main(string[] args) {
  Temp t = new Temp();
  Console.WriteLine(t.num);
}
*/

//3

//Fill in the blanks to make a valid working program.

static void Func()
 {

  Console.Write("Hi there");

} 

static void Main(string[] args) {

  Func();

}

/*
What is the value of x after this code?
int[] arr = {8, 5, 4};
Array.Reverse(arr);
double x = Math.Pow(arr[0], 2);
*/

//16

//Fill in the blanks to define a valid indexer:

public int this[int index] {

  get {

    return n[index];

  }

  set {

    n[index] = value;

  }

}

//Fill in the blanks to overload the minus operator for the T class:

public static T operator- (T a, T b) {

  T res = new T(a.num - b.num);

  return res;

}

// 57 Lesson

/*
Dance


In a ballroom dancing competition, each dancer from a pair is evaluated separately, and then their points are summed up to get the total pair score.
The program you are given takes the names and the points of each dancer as input and creates a DancerPoints objects for each dancer, using the taken name and score values as parameters for constructors.
Complete the given class, using overload + operator to return an new object where the names of dancers are in one string (see sample output) and the score is equal to the sum of their points.
The declaration of that object and the output of its points are already written in Main().

Sample Input
Dave
8
Jessica
7

Sample Output
Dave & Jessica
15
*/

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public static DancerPoints operator +(DancerPoints dancer1,DancerPoints dancer2)
            => new DancerPoints(dancer1.name + " & " + dancer2.name, dancer1.points+dancer2.points);

    }
}