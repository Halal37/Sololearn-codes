// 21 Lesson

//In Java, an array starts counting from...

//0


//Initializing Arrays
//What is the output of this code?
//int tmp[ ] = {5, 8, 9, 3};
//System.out.println(tmp[2]);

//9


//22 Lesson

//Fill in the blanks to retrieve the number of elements in an array called "test".

test.length

//Fill in the blanks to calculate the sum of myArray's elements using the for loop, and print it to the screen. myArray is an array of doubles, containing 4 elements.
double sum = 0.0;

for (int x = 0; x < 4; x++) {

 sum += myArray[x];

}

System.out.println(sum);

//23 Lesson

//Fill in the blanks to use the enhanced for loop for an array called "arr":
int total = 0;

for(int x:arr) {

   total += x;

}

//24 Lesson

//What is the output of this code?
/*String array[ ][ ] =  { {"Hey", "John", "Bye"},
{"John", "Johnson", "Hello"} }; 
System.out.println(array[1][1]);
*/

//Johnson

/*What is the output of this code?
int array[ ][ ] =  {{3, 5, 8}, {7, 54, 1, 12, 4}}; 
System.out.println(array[0][2]);
*/

//8

//25 Lesson

/*
What is the output of this code?
int arr[ ] = new int[3];
for (int i = 0; i < 3; i++) {
   arr[i] = i;
} 
int res = arr[0] + arr[2];
System.out.println(res);
*/

//2

/*
What is the output of this code?		
int result = 0;
for (int i = 0; i < 5; i++) {
  if (i == 3) { 
     result += 10;
   } else {
     result += i;
   }	
}
System.out.println(result);
*/

//17

//Fill in the blanks to calculate the sum of all elements in the array "arr" using an enhanced for loop:
int res = 0;

for
(int el: arr) {

  res += el;

}

//26 Lesson

/*
Reverse a String


Write a program to take a string as input and output its reverse.
The given code takes a string as input and converts it into a char array, which contains letters of the string as its elements.

Sample Input:
hello there

Sample Output:
ereht olleh
*/

import java.util.Scanner;

public class Program
{
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String text = scanner.nextLine();
		char[] arr = text.toCharArray();
		
		for(int i=arr.length-1; i>=0; i--){
			System.out.print(arr[i]);
		}
		
	}
}