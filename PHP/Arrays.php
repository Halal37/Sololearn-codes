<?php

// 17 Lesson

//What is the index of the first element of the array?

//0

//Fill in the blanks to output "PHP is awesome" to the screen.
<?php

$arr[0] = 'PHP';

$arr[1] = 'awesome';

$arr[2] = ' is ';

echo "$arr[0] $arr[2] $arr[1]" ;

?>

// 18 Lesson

//Which syntax corresponds to the associative array?

//'key' => value

//Fill in the blanks to output the age from the array.
<?php

$man = array("name"=>"John", "age"=>"25");

echo $man['age'];

?>

// 19 Lesson

//How many dimensions are possible in a multi-dimensional array?

//As many as you want

//Fill in the blanks to declare a two-dimensional array.
<?php

$cars = array (

  'BMW' => array('X5', 'red', '2013'),			

  'AUDI' => array('A4', 'white', '2008')

);

?>

// 20 Lesson

//A numeric array stores each array element with a numeric index.

//True

/*
Which statement will be displayed in the browser?
<?php 
$array[0] = "the mall";
$array[1] = "David";
$array[2] = "brother";
$array[3] = "the store";
$array[4] = "Rob";
echo "$array[1] went to $array[3]";
?>
*/

//David went to the store

/*
In the following example, the numeric index is automatically assigned.
<?php 
$items = array("Ball","Shoe","Dress");
?>
*/

//True
?>