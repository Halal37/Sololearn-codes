<?php

// 21 Lesson

//Fill in the blanks to output "Welcome", if the variable 'age' is greater than 18.
if($age > 18)

{
   
echo "Welcome";

}

//Drag and drop from the options below to print "YES" if the variable 'num' is equal to 100, "NO" if it is not.
if($num == 100)
{
echo "YES";
} 
else
{
echo "NO";
}


// 22 Lesson

//How many times can an elseif statement be used?

//As many as you want

//Fill in the blanks to print "Male" if the variable "gender" is equal to 0, "Female" if it is equal to 1, and "Undefined" in all other cases.
if($gender == 0)

   echo "Male";

elseif($gender == 1)

   echo "Female";

else

   echo "Undefined";

// 23 Lesson

//What is the syntax for the while loop?

//while ( ) { }

//Fill in the blanks to print the numbers 1 to 15 to the screen.
$i = 1;

while($i <= 15)   {

    echo $i;

    $i++;

}

// 24 Lesson

/*
How many times will the following code print "Hello"?
$i = 1;
do {  echo "Hello"; }
while($i < 0);
*/

//1

//Rearrange the blocks to form a correct do while loop.

$i = 0;
do {
	i++;
}while ($i < 10);

// 25 Lesson

//Which is the correct syntax for the classic for loop?

//for (expr1; expr2; expr3)

//Drag and drop from the options below to print the variable "name" 10 times.
$name = "Bruce";

for($i=0; $i<10; $i++)   {

   echo $name; 

}

// 26 Lesson

//Fill in the blanks to print the elements of the array using the foreach loop.
$items = array("one", "two", "three");

foreach($items as $item)   {

   echo $item."<br />";

}

// 27 Lesson

//The Switch statement is a replacement for...

//if elseif else statement

//Fill in the blanks.
$i = 1;

switch($i) {
  
case "1":

    echo 'One';

    break;

  case "2":

    echo 'Two';

    break;

}

//What keyword is used to handle cases that are not defined with the case keyword?

//default

/*
What output results from the following code?
$mo = "December";
switch ($mo) {
case "July":
    echo "Summer";
break;
case "January":
case "February":
    echo "Winter";
}
?>
*/

//Nothing

// 28 Lesson

//Fill in the blanks to break out of the loop after the number 5 is printed to the screen.
for ($i=0;$i<=50;$i++)  {

  echo $i;

  if ($i==5) {

    break;

  }

}

// 29 Lesson

//Fill in the blanks to print all the numbers from 0 to 15, except for the numbers 10 and 14.
for ($i=0; $i<=15;$i++) {

  if ($i==10 || $i==14) {

    continue;

  }

  echo $i."<br />";

}

// 30 Lesson

//Which is the correct syntax for the include statement in PHP?

//include 'file.php';

//Fill in the blank to include the file header.php

//include 'header.php';

//What is the difference between include and require?

//The way they handle errors

// 31 Lesson

//Using the for loop, print only the even numbers between 0 and 10.
for ($i=0; $i<=10;$i++) {

    if($i%2 != 0){

	continue;

    }

    echo $i."<br/>";
}

/*
What output results from the following code?
$x = 0;
while($x<=7) {
   $x++;
}
echo $x;
*/

//8

//The PHP Else If statement must be preceded by an If statement before it can be used.

//True

/*
What output results from the following code?
$x = 6;
if ($x ==  10) {
      echo "A";
}
elseif ($x > 7 && $x < 10) {
       echo "B";
}
elseif ($x == 20) {
       echo "C";
}
else {
       echo "D";
}
*/

//D

?>