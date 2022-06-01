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