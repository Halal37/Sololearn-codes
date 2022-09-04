// 24 Lesson

//What is a function?

//A certain block of code that can be reused over and over again

//Add the corresponding keyword and symbols to create a function named "test".

function test() 

{

   /* some code */

}

//Fill in the blanks to define and call the "hello" function.

function hello() {

   alert("Hi there");

}

hello();

//How many times can the function be executed inside a web page?

//As many as needed

// 25 Lesson

//What do you need to do to create a parameter?

//Write a variable name in the parentheses

//When and how is the parameter used?

//By calling the function and placing the value in the parentheses

//Drag and drop from the options below to declare a function and call it, by passing "Test" as the argument:

function myAlert(txt) {

   alert("Hello " + txt);

}

myAlert("Test");

// 26 Lesson

//What character is used to separate parameters from each other?

//,

/*
What is the output of this code?
function test(x, y) {
  if(x>y) {
    document.write(x);
  }
  else {
    document.write(y);
  }
}
test(5, 8);
*/

//8

//Fill in the blanks to create a function alerting the sum of the two parameters.

function myFunction(x, y)

{

  alert(x + y);

}

//How many times can the declared function be used?

//Any

// 27 Lesson

//When is the "return" statement most frequently needed?

//When you need to make a calculation and receive the result

//Where is the "return" statement placed?

//At the end of the function description

//Please enter the corresponding keyword to have the result of the function below displayed on the screen:

function substrNumbrs(first, second)

{

  var result = first - second;

  return result;

}

document.write(substrNumbrs(10, 5));


// 28 Lesson

//How many parameters can be accepted by the "alert" function?

//1

//Fill in the blanks to obtain the name of the user and alert it to the screen:

var name = prompt("Enter your name:");

alert(name);

//In the "confirm" dialog box, "OK" returns true, and "Cancel" returns ...

//false

// 29 Lesson

/*
The following code will result in what value?
function test(number)
{
   while(number < 5) {
      number++;
   }
   return number;
}
alert(test(2));
*/

//5

/*
What is the output of the following expression?
function multNmbrs(a, b) {
    var c = a*b;
}
multNmbrs(2, 6);
*/

//Nothing

//Please fill in the corresponding names for the built-in dialog boxes:

prompt is for getting input from the user;

alert is for displaying a message in a box;

//Fill in the blanks to calculate the maximum of the parameters:

function max(a, b) {

  if(a >= b)

    return a;

  else

    return b;

}

//What is the correct syntax for referring to an external script called "script.js"?

<script src="script.js">

/*
What alert will display on the screen?
function test(a, b) {
  if(a > b) {
    return a*b; 
} else {
     return b / a; 
    }
}
alert(test(5, 15));
*/

//3


// 30 Lesson

/*
Currency Converter


You are making a currency converter app.
Create a function called convert, which takes two parameters: the amount to convert, and the rate, and returns the resulting amount.
The code to take the parameters as input and call the function is already present in the Playground.
Create the function to make the code work.

Sample Input:
100
1.1

Sample Output:
110
*/

function main() {
    var amount = parseFloat(readLine(), 10);
    var rate = parseFloat(readLine(), 10);
    
    console.log(convert(amount, rate));
}

function convert(amount, rate){
    return amount * rate;
}