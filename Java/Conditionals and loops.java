//11 Lesson

//Fill in the blanks to print "Yeah".
int x = 5;
if ( x == 5 ) {
System.out.println("Yeah");
}

//Fill in the blanks to print the greater number.

int x = 10;  int y = 5;

if( x > y ) {

  System.out.println(x);
}
else{

  System.out.println(y);

}

//12 Lesson

//Please fill in the missing parts of the nested if statement to print "it works!" to the screen.
int x = 37;
if (x > 22) {

if(x > 31) {

 System.out.println("it works!");

 }

}

//13 Lesson

//An if statement can contain how many else if statements?
//As many as you want

//14 Lesson

//Fill in the blank to test both conditions in the following if statement.

int age = 23;

int money = 4000;

if (age > 21 && money > 500) {

   System.out.println("Welcome");

}

/*
What is the output of the following code?
int a = 11; int b = 12;
int c = 40;
if (a > 100 || b > 3) {
  System.out.println(a); 
} else {
  System.out.println(c);
}
*/
//11

//15 Lesson

//Fill in the blanks to test the variable's value using the switch statement.

int x = 10;

switch(x) {

  case 10:

    System.out.println("A");

    break;

  
case 20:

    System.out.println("B");

    break; 

}

/*
What is the output of the following code?
int a = 11; int b = 12; int c = 40;
switch (a) {
 case 40:
   System.out.println(b);
   break;
 default:
   System.out.println(c);
}*/

//40

//Fill in the blanks to create a valid switch expression for coffee price.

int price  = switch(coffee) {

  case "Espresso", "Americano" -> 15;

  case "Latte", "Macchiato" -> 20;

  default -> 0;

};

// 16 Lesson

//Rearrange the code to produce a valid finite loop which prints a text to the screen in the loop.

int x = 12;

while (x < 100){
	System.out.println("Java rocks!");
x++;}

/*
How many times will the following loop work?
int x = 0;
int y = 5;
while (x < y) {
  System.out.println("Hello");
  x++;	
}
*/
//5

//17 Lesson

//Drag and drop from the options below to print "Great!" 10 times:

for (int i = 0; i < 10; i++) {

   System.out.println("Great!");


}

//How many times will the following loop run?
//for (int i = 2; i < 10; i = i*i) {
//   System.out.println(i);
//}
//2

//18 Lesson

//How is a do while loop different from a while loop?

//A do while loop runs your code at least one time.

//Fill in the blanks to print the values of the x variable 5 times.


int x = 1;

do {

 System.out.println(x);

 x++;

} 

while(x <= 5);

//19 Lesson

//Fill in the blanks to print "in a loop" 7 times, using the while loop.
int x = 1;

while (x <= 7) {

  System.out.println("in a loop");
  
x++;

}

//Please select the correct statements about && and || operators.

// a || b is true if either a or b is true
//( a || b) && c is true if c is true and either a or b is true

//Fill in the blanks to print "You rock!" if variable "a" is greater than 15, and variable "b" is less than or equal to 72.
int a = 144;

int b = 33;

if (a > 15 &&b <= 72) {

  System.out.println("You rock!");

}

//Fill in the blanks to print "in a loop" 5 times using the for loop.
for
 (int x = 0; x < 5; x++) {

  System.out.println("in a loop");

}


//20 Lesson

/*
Loan Calculator

You take a loan from a friend and need to calculate how much you will owe him after 3 months.
You are going to pay him back 10% of the remaining loan amount each month.
Create a program that takes the loan amount as input, calculates and outputs the remaining amount after 3 months.

Sample Input:
20000

Sample Output:
10628

Here is the monthly payment schedule:
Month 1
Payment: 10% of 20000 = 2000
Remaining amount: 18000
Month 2
Payment: 10% of 18000 = 1800
Remaining amount: 16200
Month 3:
Payment: 10% of 16200 = 1620
Remaining amount: 14580
*/

import java.util.Scanner;

public class Program
{
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int amount = scanner.nextInt();
		int loan = 20000;
		for (int i=0;i<=2;i++){
			loan = loan - loan * 1/10;
		}
		System.out.println(loan);
	}
}