<?php

// 47 Lesson

//An object is an instance of a class.

//True

//Fill in the blanks to declare a class Student with a sayHi() method:
class Student {

  public $name;

  public $age;

  public function sayHi() { echo "Hi!"; }

}

//Create a "dog" object which is an instance of the "Animal" class.
$dog = new Animal();

//Fill in the blanks to declare a class Student and a method that prints its name and age properties.
class Student {

  public $name;

  public $age;

  public function printData() {
    
echo $this->name;

    echo $this->age;

  }

}

// 48 Lesson

//Fill in the blanks to implement a constructor method for the User class.
class User {

  public function __
construct(){

    echo "constructed";

  }

}

$n = new User();

/*
What is the output of the following code?
class TestMe {
  public function __construct() { echo "2"; }
  public function __destruct() { echo "1"; }
}
$test = new TestMe();
unset($test);
*/

//21

// 49 Lesson

//Fill in the blanks to define a class Singer that inherits from the Musician class.
class Musician {

  public $name;

  public function toPlay() {

    echo "Playing on piano";

  }

}

class Singer extends Musician {

}

//Which of the following defines a visibility control allowing access only from subclasses?

//protected

//Fill in the blanks to define an interface IMusician with a declaration for the play() method. Then, define a Guitarist class that implements IMusician and its play method.
interface IMusician {

  public function play();

}

class Guitarist implements
 IMusician {

  public function 
play
() { 

    echo "playin a guitar";

  }

}

/*
What is the output of the following code?
abstract class Calc { 
  abstract public function calculate($param); 
  protected function getConst() { return 4; }
} 
class FixedCalc extends Calc {
  public function calculate($param) {
    return $this->getConst() + $param;
  }
}
$obj = new FixedCalc();
echo $obj->calculate(38);
*/

//42

// 50 Lesson

//Fill in the blanks to declare a static property 'name' and access it from a static method in a class definition.
class Singer {

  static $name = "Jone";

  static function toSing() {

    echo self::$name;

  }

}

Singer::toSing();

//Fill in the blanks to define a "Father" class with a final method useMoney() that cannot be overridden in its "Son" subclass.
class Father {

  
final function useMoney() {

    echo "wisely";

  }

}

class Son extends Father {

  public function sayHi() {

    echo "Hi!";

  }

}

// 51 Lesson

//What does OOP stand for?

//Object Oriented Programming

//The process of creating an object of a class is called:

//instantiation

//Fill in the blanks to declare a class Singer having a display method that outputs the name. Then, create an object of the class and call the display method.
class Singer {

  public $name = "Ann";

  public function display() {

    echo $this->name;

  }

}

$s = new Singer();

$s->display();

//Fill in the blanks to define the Guitarist class that implements the MusicianInterface. Call the play() method on the Guitarist object.
interface MusicianInterface {

  public function play();

}

class Guitarist implements MusicianInterface {

  public function play() {

    echo "La La La";

  }

}

$obj = new Guitarist();

$obj->play();

//Which keyword is used to refer to properties or methods within the class itself?

//this

/*
The Foo() method cannot be overridden in a child class. Why?
class A {
  final function Foo() {
    echo "A";
  }
}
class B extends A {
  function Foo() {
  echo "B";
  }
}
*/

//final methods cannot be overridden

?>