<?php

// 43 Lesson

//Drag and drop from the options below to open a file called 'test.txt' for writing.
fopen('test.txt','w' );

//What is the symbol for a new line in a text file?

//\n

//Rearrange the code to write 12 to the file 'num.txt'.

$handle = fopen('num.txt','w');
fwrite($handle, '1');
fwrite($handle,'2');
fclose($handle);

// 44 Lesson

//Which of the following is not a supported file access mode for the fopen function?

//d

//Fill in the blanks to open the file using append mode, write to it, and close it.
$h = fopen('my.txt', 'a');

fwrite($h, 'test');

fclose($h);

// 45 Lesson

//Which function is used to read the content of a file?

//file()

//Which function was used to get the number of elements in the array?

//count

// 46 Lesson

//Which is the correct way to open the file "time.txt" as readable?	

//fopen("time.txt","r");

//Fill in the blanks to read and output the content of the file "nums.txt".
$nums = file("nums.txt");

foreach($nums
 as $num) {

   echo $num."<br />";

}

//Fill in the blanks to write the numbers 1 to 10 to the file.
$h = fopen('file.txt', 'a');

for($i=1;$i<=10; $i++) {

   fwrite($h, $i);

}

fclose($h);

?>