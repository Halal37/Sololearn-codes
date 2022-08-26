// 34 Lesson

//To use custom data types, you need to define

//a class

//The process of creating objects is called:

//instantiation

//Which of the following determines the current state of an object?

//properties

// 35 Lesson

//The area in memory that stores the contents of a value type is called:

//stack

//Which memory is used for dynamic allocation?

//Heap

// 36 Lesson

//Fill in the blanks to create a class called Car.
class Car

{


  string color;

  int year;

}

//Fill in the blanks to create an object of type Car and call its horn() method.

Car c = new Car();

c.horn();

//Assign 7 to the age property of the object.

Dog d = new Dog();

d.age = 7;

// 37 Lesson

//Encapsulation allows you to:

//Hide details of a class realization

//Which one is NOT an access modifier in C#?

//closed

//Fill in the blanks to declare a Person class, hide the age member, and make it accessible through the GetAge method.

class Person {

  private int age;

  public int GetAge() {

    return age;

  }

  public void SetAge(int n) {

    age = n;

  }

}


// 38 Lesson

//When is the constructor called?

//When a class object is created

/*
What is the output of this code?
class Dog
{
  public Dog()
  { Console.WriteLine(1); }

  public Dog(string name)
  { Console.WriteLine(name); }
}
static void Main(string[] args)
{
  Dog d = new Dog("2");
}
*/

//2

// 39 Lesson

/*
Which of the following are accessors?
Select All That Apply
*/

//set
//get

//Fill in the blanks to define valid get and set accessors for the age member:
class Dog

{

  private int age;

  public int Age

  {

    get { return age; }

    set { age = value; }

  }

}

//Skipping which accessor creates a read-only property?

//set

//Fill in the blanks to create a read-only property X. The return value of the accessor should be the square of x.
class A {

  private int x=8;

  public int X {

    get { return x*x; }

  }

}

//Fill in the blanks to create an auto-property named Age of type int.
class Dog

{

  public int Age { get; set; }

}


// 40 Lesson

//Objects of a class are stored on the:

//heap

//Fill in the blanks to instantiate an object of the class Cat, passing to the constructor the value 12. Then call the Meow method for that object:
Cat c = new Cat(12);

c.Meow();

//To make a member of a class accessible from outside the class declaration, you should declare it as:

//public

//Which statement is true?

//An object is an instance of a class.

//Fill in the blanks to declare a class Student, with one public method called Hello. The Hello method displays "hi" to the screen.

class Student {

  public void Hello() {

    Console.WriteLine("hi");

  }

}

//Fill in the blanks to declare a constructor that has one parameter and assigns it to the age member:

class Dog

{

  private int age;

  public Dog(int val)

  { 

    age = val;

  }

}

//Which accessor is used to read the value of a member?

//get

// 41 Lesson

