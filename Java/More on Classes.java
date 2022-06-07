// 42 Lesson

//Drag and drop from the options below to create a valid Java code with encapsulation.
public class Person {				
 
 private int age;
 
 public void setAge(int age) {

     if (age > 0) {

        this.age = age;

      }

   }

}

// 43 Lesson

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

// 44 Lesson

//Briefly, polymorphism is...

//... one method, with different implementations

// 45 Lesson

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

// 46 Lesson