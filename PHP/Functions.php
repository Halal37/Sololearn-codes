<?php

// 32 Lesson

//Which of the following is a correct name for a function?

//_hello()

//Drag and drop from the options below to create a function called myFunc and then call it:
 
function myFunc()  {

   echo "PHP is awesome!";

}

myFunc();

// 33 Lesson

/*
What output results from the following code?
function test($num) {
    echo $num/2;
}
test(14);
*/

//7

//Fill in the blanks to define the function "myMul", which takes two parameters and prints the product of their multiplication.
function myMul($num1,$num2)  {

	echo $num1 * $num2;

}

// 34 Lesson

//Rearrange the code to create a function which returns the sum of its parameters, and call it for 5 and 6 as its parameters.

function sum($num1, $num2){
	$sum = $num1 + $num2;
return $sum; }
echo sum(5,6);

// 35 Lesson

/*
What output results from the following code?
function func($arg)  {
  $result = 0;
  for($i=0; $i<$arg; $i++) {
    $result = $result + $i;
  }
  return $result;
}
echo func(5);
*/

//10

//Fill in the blanks to output "Welcome Robert".
function greet($name)   {

  return "Welcome ".$name;

}

echo greet('Robert');

//Fill in the blanks to declare a function myFunction, taking two parameters and printing the product of their multiplication to the screen.
function myFunction($a, $b) {

  echo $a * $b;

}

?>