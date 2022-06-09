// 41 Lesson

//Drag and drop from the options below to create a valid Java code with encapsulation.
public class Person {				
 
 private int age;
 
 public void setAge(int age) {

     if (age > 0) {

        this.age = age;

      }

   }

}

// 42 Lesson

//Fill in the blank to inherit the Car class from the Vehicle class.
class Car extends Vehicle { }

//Fill in the blanks to inherit from the Animal class and call its method in main.
class Animal {

   public void makeSound() {

   System.out.println(''Hi'');

   }

}

class Dog extends
 Animal {

}

class A {

   public static void main(String args[ ]) {

   Dog dog = new Dog();
   
   dog.makeSound();

   }

}

//Private methods are inherited from the super class.

//False

// 43 Lesson

//Briefly, polymorphism is...

//... one method, with different implementations

// 44 Lesson

//Overridden methods should have the same return type and arguments as the parent method.

//True

/*
What is the output of this code?
class A {
   public void doSomething() {
     System.out.println("A");
   }
   public void doSomething(String str) {
     System.out.println(str);
   }
}
class B {
   public static void main(String[ ] args) {
   A object = new A();
   object.doSomething("B");
   }
}
*/

//B

// 45 Lesson

//A class containing an abstract method is an abstract class.

//True

//Fill in the blanks to create an abstract class with an abstract method and inherit from it.

abstract class Animal {

  public int age;

  public abstract int printAge();

}

class Dog extends Animal {

  public int printAge() {

    return age;

  }	

}

// 46 Lesson

//In Java, how many superclasses can your inherited subclass have?

//only one

//Drag and drop from the options below to implement an interface.
interface Animal {

   public void eat();

}

class Cat implements Animal {

   public void eat() {

      System.out.println("Cat eats");

   }

}


// 47 Lesson

/*
What is the output of this code?
public static void main(String[ ] args) {	
  double x = 1.5;
  double y = 2.65;
  sum((int)x, (int)y);
}
static void sum(int x, int y) {
   System.out.println(x + y);
}
*/

//3


// 48 Lesson

/*
What is the output of this code?
class A {
   public void print() {
      System.out.println("A");
   }
}
class B extends A {
   public void print() {
      System.out.println("B");
   }
   public static void main(String[ ] args) {
    A object = new B();
    B b = (B) object;
    b.print();
   }
}
*/

//B

// 49 Lesson

//Fill in the blanks to override the start method of the Machine class.
Machine m = 
new Machine() {

   
@Override public void start() {

      System.out.println("Hi");

   }

}

//Drag and drop from the options below to print "Hello".
class A {

   public void print() {

   System.out.println("A");

   }		

}

class B {				

   public static void main(String[ ] args) {	
 
   A object = new A() {


      @Override public void print() {

       System.out.println("Hello");

       }

    };

    object.print();

   }		

}

// 50 Lesson

//Rearrange the code to have an inner class Hand, which has a method called "shake" that prints "Hi".

public class Person {
class Hand{
	public void shake(){
	System.out.println("Hi");}
}}

// 51 Lesson

/*
What is the output of this code?
class A {
 private int x;	
 public static void main(String[ ] args) {
   A a = new A();
   a.x = 5;
   A b = new A();
   b.x = 5;
   System.out.println(a == b);			
 }
}
*/

//false

//Drag and drop from the options below to check whether the two objects of type A are semantically equal.
class A {

   private int x;

   public boolean equals(Object o) {
    
   return ((A)o).x == this.x;
   }	

   public static void main(String[ ] args)  {

    A a = new A();

    a.x = 9;

    A b = new A();

    b.x = 5;

    System.out.println(a.equals(b));

   }

}


// 52 Lesson

//Enums are used to declare variables that represent...

//members of a fixed set

//Drag and drop from the options below to create an Enum called "Color", with the values RED, BLUE, GREEN.
public enum Color  {

  RED, BLUE, GREEN;

}

/*
What is the output of this code?
enum Color  {
  RED, BLUE, GREEN;
}
class PrintColor {
   public static void main(String[ ] args) {
   Color color = Color.RED; 
   switch(color) {
   case BLUE:
     System.out.println("1");
   break;
   case GREEN:
     System.out.println("2");
   break;
   default:
     System.out.println("0");
   break;		 
   }
}
}
*/

//0
 
 
// 53 Lesson

//Fill in the blank to import all types in the package awt.
import java.awt.*;


// 54 Lesson

/*
What is the output of this code?
class A {
   private void print() {
     System.out.println(''a'');
   }
   private void print(String str) {
     System.out.println(''b'');
   }
   private void print(int x) {
     System.out.println(''c'');
   }		
   public static void main(String[ ] args) {	
     A object = new A();
     object.print(12);	
   }	
}
*/

//c

//Fill in the blanks to define a new class Falcon, based on the superclass Bird.
class Falcon extends Bird {

 }

//Object variables store...

//References

//What term is used for hiding the details of an object from the other parts of a program?

//Encapsulation

//A class Car and its subclass BMW each have a method run(), which was written by the developer as part of the class definition. If CarObj refers to an object of type BMW, what will CarObj.run(); do?

//The run() method defined in BMW will be called.

/*
Valentine, Holiday, and Birthday inherit from the class Card. In order for the following code to be correct, what type must the reference variable card be?
card = new Valentine( "A", 14 ) ;
card.greeting();

card = new Holiday( "B" ) ;
card.greeting();

card = new Birthday( "C", 12 ) ;
card.greeting();
*/

//Card

// 55 Lesson

/*
Shapes


You are working on a graphical app, which includes multiple different shapes.
The given code declares a base Shape class with an abstract area() method and a width attribute.
You need to create two Shape subclasses, Square and Circle, which initialize the width attribute using their constructor, and define their area() methods.
The area() for the Square class should output the area of the square (the square of the width), while for the Circle, it should output the area of the given circle (PI*width*width).
The code in main creates two objects with the given user input and calls the area() methods.

Sample Input:
5
2

Sample Output:
25
12.566370614359172

The area of the square is 5*5=25, while the area of the circle is PI*2*2=12.566370614359172
*/
import java.util.Scanner;

abstract class Shape {
    int width;
    abstract void area();
}

class Square extends Shape{
    public Square(int x){
        width=x;
    }
    void area(){
    System.out.println(width*width);
    }
}

class Circle extends Shape{
    public Circle(int x){
        width=x;
    }
    void area(){
    System.out.println(Math.PI*width*width);
    }
}

public class Program {
    public static void main(String[ ] args) {
        Scanner sc = new Scanner(System.in);
        int x = sc.nextInt();
        int y = sc.nextInt();
        
        Square a = new Square(x);
        Circle b = new Circle(y);
        a.area();
        b.area();
    }
}