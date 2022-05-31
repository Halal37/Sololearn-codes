//2 Lesson

//The main Method
//Fill in the blank to declare a method called "hello()".
void hello();
//Which method prints text in a Java program?
System.out.println();
//Fill in the blanks to create a valid Java program.
class
 Apples {

    public static void 
main
(String[ ]args) {

    System.out.println("Hello, World!");

   }

}

//3 Lesson

//Single-line comments are created using:
// characters at the beginning of the line

//Make this text a multi-line comment.
/*
 some

* comment text

*/

//You can add a Java doc style comment by using:
/** and */ characters to wrap a comment.

//4 Lesson

//Which variable type would you use for a city name?
//String

//Drag and drop from the options below to have a valid Java program.

class Apples {

  public static void main(String[ ]args) {  
 name = "John";    
 age = 24;    
 height = 189.87;
  }
}

//5 Lesson


//Drag and drop from the options below to get user input.
import java.util.Scanner;
class test {
   public static void main(String[ ] args) {      
 Scanner sc = new Scanner(System.in);
      String st = sc.nextLine();
   }
}

//6 Lesson

//Fill in the blank to declare an integer variable and set its value to 5.
int var= 5;

//Fill in the blanks to print the sum of the two variables.
int x = 2; int y = 4;

int result = x + y;
System.out.println(result);

//What is the result of the following code?
//int x = 15; int y = 4;
//int result = x / y;
//System.out.println(result);

//3

//What value is stored in the result variable?
//int x = 8, y = 5;
//int result = x % y;

//3

//7 Lesson

//Fill in the blanks to print 11.

int a = 10;
++a;
System.out.println(a);

//What is the output of the following code?
//int x = 14; 
//System.out.println(x++);

//14

//Fill in the missing parts in the following code to print 13.
int x = 25; int y;
y = x - 12;

System.out.println(y);

//8 Lesson

//Drag and drop from the options below to print "Hello".
String var;
var = "Hello";
System.out.println(var);

//Which statement in regard to the char data type is true?

//'k' is a char

//9 Lesson

//Please type in a code to declare two variables of type int and print their sum using the sum variable.

int x = 4;

int y = 7;

int sum = x+y;
System.out.println(sum);

//In every Java program...

//...there must be a method called "main".

//Drag and drop from the options below to output the name:
String name;
name = "David";
System.out.println(name);

/*You need a program to convert days to seconds.
The given code takes the amount of days as input. Complete the code to convert it to seconds and output the result.

Sample Input:
12

Sample Output:
1036800*/

import java.util.Scanner;

public class Program {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int days = scanner.nextInt();
		int hours = 24;
		int minutes = 60;
		int seconds = 60;
		int result;
		result = days * hours * minutes * seconds;
		System.out.println(result);
		
	}
}









