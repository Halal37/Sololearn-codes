// 27 Lesson

//A class defines... (choose two)
//Select All That Apply

//attributes
//behavior

// 28 Lesson

//Fill in the blanks to call the method "hello" from main:
public static void main(String[ ] args) {

   hello();

}

static void hello() {

   System.out.println("hi");

}

//Calling Methods
//How many times can you call a method?

//as many as you want

/*
What output results from this code?
public static void main(String[ ] args) {
   doSomething(4);
}	 
static void doSomething(int x) {
   System.out.println(x*x); 
}
*/

//16

/*
You are creating a robot, "Welcomer 2000", that never fails to greet a single person it encounters. You provide the number of people that will enter the room, and the robot will shout "Welcome" that number of times.
The program you are given already takes a number as input and calls the method according provided count. The issue is that the method is incomplete. Fix it.

Sample Input
2

Sample Output
Welcome!
Welcome!
*/

import java.util.Scanner;

public class Main {

   public static void main(String[] args) {
       Scanner read = new Scanner(System.in);
       int numberOfPeople = read.nextInt();
       
       for (int i = 0; i < numberOfPeople; i++) {
           welcome();
       }
   }
   public static void welcome() {
       System.out.println("Welcome!");
       
   }
}


// 29 Lesson

//If you do not want your method to return anything, you should use the keyword:

//void

//Fill in the blanks to declare an integer, and pass it as a parameter to the test() method.
public static void main(String[ ] args) {
   
int x = 10;

   test(x);

}

static void test(int x) {			

   System.out.println(x);

}

/*
What output results from this code?
public static void main(String[ ] args) {
  int x = 10;
  int y = myFunc(x);
  System.out.println(y);
}
public static int myFunc(int x) {
  return x*3;
}
*/

//30

// 30 Lesson

//Fill in the blanks to create a class with a single method called "test".
public class A {

  public void test() {

    System.out.println(''Hi'');

  }  

}

//Drag and drop from the options below to create an object of the A class in the B class and call its "test" method.
public class A {


  public void test() {


    System.out.println("Hi");


  }	 


}


class B {

  public static void main(String args[ ]) {
  
 A obj = new A();

    obj.test();

  }


}

// 31 Lesson

//Drag and drop from the options below to define a class with these attributes: age of type integer, height as a double, and name as a string.
 class Person {
  
 int age;
  
 double height;
 
 String name;

}

//Fill in the blanks to create two objects from the class "People".
People obj1 = new People();

People obj2 = new People();

//32 Lesson

//Which of the following are valid access modifiers?
//Select All That Apply

//public
//private
//protected

//33 Lesson

//Drag and drop from the options below to define the set and get methods.
class A {

   private int x;			

   public int getX() {

    return x;

}


   public void setX(int x) {

    this.x = x;

   }

}

//What would the name of the setter method for the class variable named "age" be?

//setAge

// 34 Lesson

//Drag and drop from the options below to create a valid constructor.
class Person {

   private int age;

   public Person(int myage) {

      age = myage;

   }

}

//True or false: The constructor must have the same name as the class.

//True

//Fill in the blanks.
class A

{

  private int x;

   public A(int val) {

     x = val;

   }

}


// 35 Lesson

/*
What is the output of this code?
public static void main(String[ ] args) {
   int x = 4;
   square(x);
   System.out.println(x);		
}
static void square(int x) {
   x = x*x;
}
*/

//4

/*
What is the output of this code?
public static void main(String[ ] args) {
  Person p = new Person();
  p.setAge(25);
  change(p);
  System.out.println(p.getAge());
}
static void change(Person p) {
  p.setAge(10);
}
*/

//10


// 36 Leson