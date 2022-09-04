// 7 Lesson

/*
What will the following statements display?
var test=5+7;
document.write(test);
*/

//12

//What character do we use for multiplication?

//*

//What character do we use for division?

// /

//What’s the result of using a modulus operator for 38%5?

//3

//What are increment and decrement are used for?

//Adding or subtracting 1 from a number

// 8 Lesson

/*
Calculate and enter the resulting value of this expression:
var number = 20;
number *= 5;
*/

//100

// 9 Lesson

//What do comparison operators return?
//Select All That Apply

//false
//true

//Enter the corresponding operators according to the comments at right.

val1 == val2 // are equal

val1 != val2 // not equal

val1 < val2 // less than

val1 === val2 // are strict equal (identical)


// 10 Lesson

//Logical AND (&&) returns true if:

//If both operands are true

//Logical NOT returns true, if: 

//The operand is false

// 11 Lesson

/*
What’s the output of the following code?
var x = "50";
var y = "100";
document.write(x+y);
*/

//50100

// 12 Lesson

//Which of these names are acceptable for JavaScript variables?

//firstNumber
//module

//Fill in the data types of the data shown below in the comments field:

12 // number

"some text" // string

true // boolean

//What's the result of the expression var1&&var2, if var1=true and var2=false?

//false

// 13 Lesson

/*
Trip Planner


You need to plan a road trip. You are traveling at an average speed of 40 miles an hour.
Given a distance in miles as input (the code to take input is already present), output to the console the time it will take you to cover it in minutes.

Sample Input:
150

Sample Output:
225
*/

function main() {
    var distance = parseInt(readLine(), 10);
    var output = 60* distance/40
    console.log(output)
    
}