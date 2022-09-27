// 37 Lesson

//What two keywords do we need to create an array?
//Select All That Apply

//Array
//new

/*
What is the output of this code?
var arr = new Array(3, 6, 8);
document.write(arr[1]);
*/

//6

//What is the result of trying to reference an array member which does not exist?

//undefined

// 38 Lesson

//Please insert the missing characters to output the third member of the array:

document.write(example[2]);

//By entering var example = new Array(); we create an empty array which can be filled...

//anytime later

// 39 Lesson

//Array has the "length" property, because it is:

//an object

//The "concat" method takes two arrays and:

//combines them in one new array

// 40 Lesson

//In associative arrays, index numbers are replaced with:

//strings

//In order to use associative arrays, the "associated" name is put in:

//brackets [ ]

// 41 Lesson

//In the Math Object, which of the following constants does NOT exist?

//Math.ABC

//In the Math Object, which of the following methods is used to calculate the square root?

//sqrt

/*
What is the result of the following expression:
Math.sqrt(81);
*/

//9

// 42 Lesson

//Fill in the blanks to call the function "calc()" every 2 seconds:

setInterval(calc, 2000);

//What information results from creating a Date Object?

//The current date and time

//Fill in the blanks to initialize a date object representing the current date and time:

var date = new Date();

// 43 Lesson

//Given the array below, please complete the expression to be alerted with "apple".

var fruits = new Array("pear", "orange",

"apple", "grapefruit");



alert(fruits[2]);

//What is the result of the following expression?
//alert(Math.sqrt(36));

//6

//Please fill in the blanks to output the current minutes:

var date = new Date();

alert(date.getMinutes());

/*
What is the output of this code?
var arr = new Array("a", "b", "c"); 
alert(arr[1]);
*/

//b

//Drag and drop from the options below to get alerted with the value of the PI constant.

alert(Math.PI);

// 44 Lesson

/*
Store Manager


You are working on a Store Manager program, which stores the prices in an array.
You need to add functionality to increase the prices by the given amount.
The increase variable is taken from user input. You need to increase all the prices in the given array by that amount and output to the console the resulting array.
*/

function main() {
    var increase = parseInt(readLine(), 10);
    var prices = [98.99, 15.2, 20, 1026];
    for (var i=0;i<prices.length;i++){
        prices[i]+=increase;
    }
    console.log(prices);
}
