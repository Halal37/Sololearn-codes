// 58 Lesson

//Assume the Employee class inherits the members of the Person class. What is the Person class called?

//The Base class

//Fill in the blanks to derive Cat from Animal:

class Cat : Animal {

  // some code

}

//How many base classes can one class have?

//one

// 59 Lesson

//Fill in the blanks to make the Area method of the Shape class accessible only in the derived class:

class Shape {

  public int H {get; set;}

  public int W {get; set;}

  protected int Area() {

    return H * W;

  }

}

//Fill in the blanks to derive a class B from class A and prevent class B from being inherited.

class A {

} sealed class B : A {

}

// 60 Lesson

//What is the maximum number of base classes a sealed class can have?

//one

/*
What is the value of x after a B object is created?
class A {
  public int x=7;
  public A() {
    x++;
  }
}
class B: A {
  public B() {
    x++;
  }
}
*/

//9

// 61 Lesson

//Briefly, polymorphism is:

//one method with different implementations

//Fill in the blanks to define a public and virtual method Bark in the Animal class:

class Animal {

  public virtual
 void Bark() {

    Console.Write("Barking.");

  }

}

//Fill in the blanks to implement the Bark method in the Dog class:

class Dog : Animal {

  public override void Bark()
 {

    Console.WriteLine("Woof!");

  }

}

/*
Class B inherits from class A. The constructor of class A displays "a", while the class B constructor displays "b".
What is output to the screen when the code A a = new B(); is run?
*/

//ab


// 62 Lesson

//Fill in the blanks to define an abstract method Print for class A:

abstract class A 

{

  public abstract void Print();


}

//Fill in the blanks to create an abstract class with an abstract method and then use it as a base class.

abstract class Animal {

  public abstract void Eat();

}

class Dog: Animal {

  public override void Eat() {

    Console.WriteLine("Omnomnom");

  }

}


// 63 Lesson

/*
Is the following interface valid?
public interface ITest {
  int test;
  void Func();
}
*/


//No

//Fill in the blanks to create an interface and implement it.

interface IAnimal {

  void Eat();

}

  class Dog: IAnimal {

  public void Eat() {

    Console.WriteLine("Omnomnom");

  }

}

/*
What is the output of this code?

public interface ISomeFunc {
  void Greet(){
    Console.Write("Hello!");
    }
  }
class SomeObject : ISomeFunc {
  void Greet() {
    Console.Write("Hi!");
    }
  }
static void Main(string[] args)
{
  ISomeFunc obj = new SomeObject();
  obj.Greet();
}
*/

//Hi!

// 64 Lesson

/*
Rearrange the code to have a nested class Hand, which has a method called "Shake" that prints "Hi".

*/
class Person{
	class Hand{
		public void Shake(){
		Console.WriteLine("Hi"); }
}}

// 65 Lesson

//Rearrange the code to create a generic C# project code structure.

using System;
namespace SoloLearn {
	class Program {
		static void Main(string[] args) {
}}}

// 66 Lesson

//Can you instantiate objects of an abstract class?

//No

//Fill in the blanks to define a new class Falcon, which is derived from the class Bird.

class Falcon : Bird {

}

//Which keyword makes class members accessible to only its derived class members?

//protected

//Fill in the blanks to declare a Person class with a Hello abstract method, and then declare a Student class that is derived from the Person class and overrides its Hello method.

abstract class Person {

  public abstract void Hello();

}

class Student : Person {

  public override void Hello() {

    Console.Write("Hello");

  }

}

//A sealed class can be marked as abstract.

//False

//Fill in the blanks to implement the A and B interfaces.
interface A {

} 

interface B {

}

class Test: A, B {

}

//Can a single class inherit from multiple abstract classes?

//No

// 67 Lesson

/*
Drawing Application


You are creating a drawing application and currently have only 1 tool - a pencil. You want to add brush and spray to the drawing toolbar.
The program you are given declares an IDraw interface with the StartDraw() method, and class Draw, which performs pencil drawing by implementing the IDraw interface. It outputs "Using pencil".
Complete the given Brush and Spray classes by
- inheriting them from class Draw
- implementing the StartDraw() method for each tool, in order to output
"Using brush" for Brush, or
"Using spray" for Spray.

The Draw objects and their method calls are provided in Main().
*/

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

        }
    }

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    class Brush : Draw
    {
        public override void StartDraw(){
            Console.WriteLine("Using brush");
        }

    }

    class Spray : Draw
    {
        public override void StartDraw(){
            Console.WriteLine("Using spray");
        }

    }
}