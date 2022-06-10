// 56 Lesson

//Which two of the following statements are true?
//Select All That Apply

// If we don't catch exceptions, the program can shut down

// Exceptions catching is a good practice


//Fill in the blanks to handle any possible exceptions.
int x = 12;

int y = 0;

try {

   int z = x / y;

   System.out.println(z);

}

catch (Exception e) {

   System.out.println("Error");

}


// 57 Lesson

//Drag and drop from the options below to create a method that throws an IOException if the parameter is negative.
public void do(int x)
  
throws IOException {

  if(x<0)

  {
    
 throw new IOException();

  }

}

//How many catch blocks can a try/catch block contain?

//As many as you need

// 58 Lesson

//Fill in the blanks to run the method in a separate thread.
class A extends Thread {

   public void run() {

      System.out.println("Hello");

   }

   public static void main(String[ ] args) {

   A object = new A();

   object.start();

   }

}

//Drag and drop from the options below to implement the Runnable interface and run a new thread.
class A implements Runnable {

   public void run() {

   System.out.println("Bye");

   }

}

public class App {

 public static void main(String[ ] args) {

   Thread ob = new Thread(new A());


   ob.start();

   }

}



// 59 Lesson

//If not handled, which exception types prevent your program from compiling?

//Checked

// 60 Lesson

//Drag and drop from the options below to declare an ArrayList to hold 9 Integers.
ArrayList<Integer> ar = 

new ArrayList <Integer>(9);

/*
What is the output of this code?
ArrayList<String> list = new ArrayList<String>();
list.add("A");
list.add("B");
list.add("C");
System.out.println(list.get(1));
*/

//B

// 61 Lesson

//Drag and drop from the options below to create a LinkedList, add "Hey", and print it.
LinkedList<String> list = 

      new LinkedList<String>();

list.add("Hey");

System.out.println(list.get(0));

//For a program with large numbers of inserts and deletes, it is better to use the...

//LinkedList

// 62 Lesson

/*
What is the output of this code?
import java.util.HashMap;
class A {	
   public static void main(String[ ] args) {
   HashMap<String, String> m = new HashMap<String, String>();
   m.put("A", "First");
   m.put("B", "Second");
   m.put("C", "Third");
   System.out.println(m.get("B"));
   }
}
*/

//Second

//Fill in the blanks to declare a HashMap, add two items, and print one of them.
HashMap<String, String> m = 
    
new HashMap<String, String>();

m.put("A", "First");

m.put("B", "Second");

System.out.println(m.get("B"));


// 63 Lesson

/*
What is the output of this code?
import java.util.HashSet;
class A {
   public static void main(String[ ] args) {
   HashSet<String> set = new HashSet<String>();
   set.add("A");
   set.add("B");	
   set.add("C");
   System.out.println(set.size());
   }
}
*/

//3

//Which two of the following statements are true?

//Set contains only unique values.
//HashSet does not retain order.

// 64 Lesson

/*
What is the output of this code?
List<String> list = new ArrayList<String>();
list.add("b");
list.add("a");
list.add("c");
Collections.sort(list);
System.out.println(list.get(0));
*/

//a

//Fill in the blanks to add three items to the list, sort it,  and print 2.
List<Integer> list = new ArrayList<Integer>();

list.add(4);

list.add(2);

list.add(1);

Collections.sort(list);

System.out.println(list.get(1));


// 65 Lesson

/*
What is the output of this code?
List<Integer> list = new ArrayList<Integer>();
list.add(10);
list.add(20);
list.add(30);
Iterator<Integer> it = list.iterator();
it.next();
System.out.println(it.next());
*/
//20

//Drag and drop from the options below to iterate and print all of the items in the list of Integers.
Iterator<Integer> it = list.iterator();

while (it.hasNext()) {

  System.out.println(it.next());	

}



// 66 Lesson

//Fill in the blanks to determine whether the file exists.
class A {

   public static void main(String args[ ]) {

   File file = new File("a.txt");

   if(file.exists()) {

     System.out.println("Yes");

   }

}

}


// 67 Lesson

//Which class can be used for reading files?

//Scanner

//Drag and drop from the options below to read and print the content of the file a.txt, and then close it.
try {

   File f = new File("a.txt");

  Scanner sc = new Scanner(f);

  while (sc.hasNext()) {

      String a = sc.next();

      String b = sc.next();

      System.out.println(a + " " + b);

  } 

  sc.close();

} 

catch (Exception e) {

   System.out.println("Error");

}


// 68 Lesson

//Which class is used to write content to files?

//Formatter

//Rearrange the code to write "Hi there" to the file.

Formatter f = new Formatter("a.txt");
f.format("%s", "Hi");
f.format("%s","there");
f.close();

// 69 Lesson

//Fill in the blanks to declare a function that takes two integers as arguments and prints their division. Handle the possible exception.
void myFunc(int a, 
int b) {
 
try {

    System.out.println(a/b);

  }
  
catch(Exception e) {

     System.out.println("Error");

  }

}

//Fill in the blanks to define a function ''myFunc'', which throws an exception if its parameter is less than 0.
void myFunc(int arg)
   
throws IllegalArgumentException

{

  
if (arg < 0)

   throw new IllegalArgumentException();

}

/*
How many lines of output will this code produce?
class B implements Runnable {
   public void run() {
     System.out.println("B");	
   }
}
class A extends Thread {
   public void run() {
    System.out.println("A");
    Thread t = new Thread(new B());
    t.start();
   }
public static void main(String[ ] args) {
   A object = new A();
   object.start();
   }
}
*/

//2

//Which two options allow you to create new threads?

//implement Runnable
//extend the Thread class

/*
What is the output of this code?
ArrayList<Integer> list = new ArrayList<Integer>();
for (int i = 0; i < 6; i++) {
	list.add(i);
}
int x = 0;
Iterator<Integer> it = list.iterator();
while (it.hasNext()) {
	x+= it.next();	
}
System.out.println(x);
*/

//15

/*
What is the output of the following code?
int f=1, i=2;
while(++i<5)
   f*=i;
System.out.println(f);
*/

//12


// 70 Lesson
/*
Bowling Game


You are creating a bowling game!
The given code declares a Bowling class with its constructor and addPlayer() method.
Each player of the game has a name and points, and are stored in the players HashMap.
The code in main takes 3 players data as input and adds them to the game.
You need to add a getWinner() method to the class, which calculates and outputs the name of the player with the maximum points.

Sample Input:
Dave 42
Amy 103
Rob 64

Sample Output:
Amy
*/

import java.util.*; 

public class Bowling {
    HashMap<String, Integer> players;
    Bowling() {
        players = new HashMap<String, Integer>();
    }
    public void addPlayer(String name, int p) {
        players.put(name, p);
    }
    public void getWinner(){
        int max=0;
        String maxString = "";
        for (String i : players.keySet()) {
            if(max<=players.get(i)){
               maxString=i;
               max=players.get(i);
            }

        }
        System.out.println(maxString);
    }
    
}

public class Program {
    public static void main(String[ ] args) {
        Bowling game = new Bowling();
        Scanner sc = new Scanner(System.in);

        for(int i=0;i<3;i++) {
            String input = sc.nextLine();
            String[] values = input.split(" ");
            String name = values[0];
            int points = Integer.parseInt(values[1]);
            game.addPlayer(name, points);
        }
        game.getWinner();
    }
}