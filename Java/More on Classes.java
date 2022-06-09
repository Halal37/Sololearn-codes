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