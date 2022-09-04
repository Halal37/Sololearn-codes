// 14 Lesson

//Add the characters that complete the statement:

if (var1 > var2)

{

   document.write("OK");
   
}

//What happens if the tested condition is false?

//The code does nothing and moves to the next section

// 15 Lesson

//The "else" statement is created to do what?

//Tell JavaScript to execute something if the condition is false

//Fill in the blanks to create a valid if...else statement:

var age = 25;

if (age >= 18) {

   alert("Allowed.");

}

else {

   alert("Not allowed.");

}


// 16 Lesson

//What keyword is used to end the "else if" statement?

//else

//Fill in the blanks to create a valid if...else...if statement:
var status = 1;

var msg;

if (status == 1) {

   msg = "Online";

}

 
else if (status == 2) {

   msg = "Away";

} 

else {

   msg = "Offline";

}


// 17 Lesson

//The switch statement can be used to replace…

//multiple if else statements

//How many "case" statements are usually used in the "switch" statement?

//One for each possible answer

/*
What’s the output of this code?
var x = 3;
switch (x) {
  case 1:
    document.write(x);
    break;
  case 2:
    document.write(x+2);
    break;
  default:
    document.write(x+5);
}
8/

//8

//The "default" statement is used …

//When no match is found

// 18 Lesson

//The classic "for" loop consists of how many components?

//3

//Fill in the blanks to compose a valid for loop:

var i = 1;

for (k=1; k<10; k++) {

   i += k;

}

//Fill in the blanks to print EVEN values from 0 to 20 using a for loop:

var x = 0;

for (; x <= 20; x += 2) {

   document.write(x); 

}


// 19 Lesson

//The result of the condition statement is always:

//A Boolean value (true or false)

//Fill in the blanks to print x's values from 1 to 5.
var x = 1;

while(x <= 5) {

    document.write(x + "<br />");

    x = x + 1;

}

//How many times will the while loop run, if we remove the counting variable increment statement?

//Infinite

// 20 Lesson

//Apply the "do" and "while" keywords in their corresponding positions.

var count=1;

do {

  document.write("hello <br />");

  count++;

}

while (count<=10);


// 21 Lesson

//The "break" statement:

//Ends the execution of the loop

/*
What’s the output of this code?
var sum=0; 
for(i=4; i<8; i++) {
  if (i == 6) {
    continue; 
  }
  sum += i;
}
document.write(sum);
*/

//16

// 22 Lesson

/*
What’s the output of this code?
var x = 0;
while(x<6) {
  x++;
}
document.write(x);
*/

//6

//Fill in the right keywords to test the conditions:

switch(day_of_week) {

  case 1:

  case 2:

  case 3:

  case 4:

  case 5:

    document.write("Working Days");

    break;

  case 6:

    document.write("Saturday");

    break;

  default:

    document.write("Today is Sunday");

    break;

}

//Please fill in the right keywords to compose a loop:

do {

   document.write(i);

    i++;

}

while (i < 10);


// 23 Lesson

/*
The Snail in the Well


The snail climbs up 7 feet each day and slips back 2 feet each night.
How many days will it take the snail to get out of a well with the given depth?

Sample Input:
31

Sample Output:
6

Explanation: Let's break down the distance the snail covers each day:
Day 1: 7-2=5
Day 2: 5+7-2=10
Day 3: 10+7-2=15
Day 4: 15+7-2=20
Day 5: 20+7-2=25
Day 6: 25+7=32
So, on Day 6 the snail will reach 32 feet and get out of the well at day, without slipping back that night.
*/

function main() {
    var depth = parseInt(readLine(), 10);
    var day = 0;
    var length = 0;
    do{
        length+=7;
        day++;
        if (length>=depth)
        break;
        length-=2;

    }while(length<depth);
    console.log(day);
    
}
