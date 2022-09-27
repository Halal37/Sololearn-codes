// 31 Lesson

//In reference to an object, color, height, weight and name are all examples of:

//properties

//What built-in property is used to count the number of characters in an object's property?

//length

//Access the "color" property of the "hair" object using dot syntax.

//hair.color

// 32 Lesson

//Fill in the blanks to create  a constructor function:

function movie(title, director) {

  this.title = title;

  this.director = director;

}

//What keyword is used for creating an instance of an object?

//new

//Which two components are necessary in order to use information contained within an object?
//Select All That Apply

//object's name
//property's name

// 33 Lesson

//Fill in the blanks:

simba = { category: "lion", 

gender: "male"}

//Complete the following expression to display the "simba" object's "category" property on the screen:

document.write(simba.category);


// 34 Lesson

//The "this" keyword in the method means:

//The current object

//Please associate the "testData" constructor function below with a method called "mymethod":

function testData (first, second) {

  this.first = first;

  this.second = second;

  this.checkData = mymethod;

}

//In order to use the object's properties within a function, use:

//The "this" keyword


// 35 Lesson

//An object's properties are similar to variables; methods are similar to:

//functions

/*
What is the result of the following expression?
var myString = "abcdef";
document.write(myString.length);
*/

//6

//Complete the expression to create an object constructor, taking into account that "height" and "weight" are properties and "calculate" is a method for the given object:

function mathCalc (height, weight) {

  this.height = height;

  this.weight = weight;

  this.sampleCalc = calculate;

}

// 36 Lesson

/*
Contact Manager


You are working on a Contact Manager app.
You have created the contact object constructor, which has two arguments, name and number.
You need to add a print() method to the object, which will output the contact data to the console in the following format: name: number
The given code declares two objects and calls their print() methods. Complete the code by defining the print() method for the objects.
*/

function contact(name, number) {
    this.name = name;
    this.number = number;
    this.print = function (){

console.log(this.name +": "+ this.number);
}


}



var a = new contact("David", 12345);
var b = new contact("Amy", 987654321);
a.print();
b.print();