<?php

// 36 Lesson

//Fill in the blank to print the current script's file path to the screen.
<?php

  $addr = $_SERVER['SCRIPT_NAME'];

  echo $addr;

?>

// 37 Lesson

//What is the $_SERVER variable?

//An array

// 38 Lesson

//Which HTML element is needed to collect user input from a web page?

//form

//Which form attribute indicates the page to which the form is submitted?

//Action

//Fill in the blanks to submit the form to a page called my.php using the POST method.
<form action="my.php"

 method="post">

 </form>

// 39 Lesson

//Fill in the blanks to print the value of a text box named "email", which was submitted using POST.
<?php

   echo $_POST["email"];

?>

//Which method was used for the following URL?
//http://www.sololearn.com/index.php?id=825

//GET

// 40 Lesson

//Type in the function that must be called before working with the session variables.

//session_start();

//Rearrange the code to declare the variable name, add it to the session, and then print it to the screen.

session_start();
$name = "Alex";
$_SESSION['name'] = $name;
echo $_SESSION['name'];

// 41 Lesson

//Where are cookies stored?

//On the user's computer

//Fill in the blanks to set a cookie named 'logged' with the value 1 and an expiration time of 1 hour.

//setcookie('logged', 1, time()+3600);

// 42 Lesson

//Which of the form submit methods should be chosen for a login page?

//POST

//Consider the following URL: www.sololearn.com/test.php?page=login.
//What is the output of the following code: 
//echo $_GET['page'];

//login

//Should you store sensitive information in cookies?

//No

//Fill in the blanks:
<form method="GET">

   <input type="text" name="name" />

   <input type="submit" />

</form>


?>