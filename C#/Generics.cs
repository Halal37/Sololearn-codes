// 74 Lesson

//Fill in the blanks to declare a generic method that displays its argument value.

static void Print<T>(T x)

{

  Console.WriteLine(x);

}

//Fill in the blanks to use the generic method Func for the x and y variables:

static void Func<T, U>(T x, U y) {

  Console.WriteLine(x+" "+y);

}

static void Main(string[] args) {

  double x = 7.42;

  string y = "test";

  Func(x, y);

}


// 75 Lesson

//Drag and drop from the options below to define a generic Store class with a generic data member x, which is initialized in the constructor.
class Store <T> {

  T x;

  public Store(T val) {

    x = val;

  }

}

//Can a custom class be used as the type for the generic class?

//Yes

// 76 Lesson

//What is true for a collection?
//Select All That Apply

//A collection is used to group related objects.
//A collection organizes related data in a computer so that it can be used efficiently

//Which namespace contains the generic collection classes?

System.Collections.Generic

// 77 Lesson

//Fill in the blanks to create a List object, add an element with the value "Hi" to it, and output the elements value.

List<string> li = new List<string>();

li.Add("Hi");

Console.Write(li[0]);

/*
What is the output of this code?
SortedList<string, int> pupil = new SortedList<string, int>();
pupil.Add("Bob", 11);
pupil.Add("Ann", 9);
pupil.Add("Mike", 12);
pupil.Remove("Ann");
foreach (string s in pupil.Keys)
  Console.WriteLine(s + ": " + pupil[s]);
*/

//Bob: 11 Mike: 12

/*
What is the output of this code?
BitArray ba1 = new BitArray(4);
BitArray ba2 = new BitArray(4);            
ba1.SetAll(true);
ba2.SetAll(false);            
ba1.Set(2, false);
ba2.Set(3, true);
Console.Write(ba1.And(ba2).Get(3));
*/

//True

// 78 Lesson

//Fill in the blanks to create a stack of integers and push 11, 42, and 15 to it. Print "yes" if the stack contains 42.

Stack<int> st = new Stack<int>();

st.Push(11);

st.Push(42);

st.Push(15);

if (st.Contains(42)) {

  Console.WriteLine("yes");

}

/*
What is the output of this code?
Queue<string> q = new Queue<string>();
q.Enqueue("A");
q.Enqueue("B");
q.Enqueue("C");
foreach (string s in q)
  Console.Write(s + " ");
*/

//A B C

// 79 Lesson

//Which method removes all the elements from the dictionary?

//Clear()

//Fill in the blanks to declare a HashSet hs of integers, insert values 1 through 5 to it and print the count of hs items.
HashSet<
int
> hs = new HashSet<int>
()
;

for
 (int x = 1; x <= 5; x++) {

  hs.Add(x);

}

Console.Write(
hs
.Count);


// 80 Lesson

/*
What is the output of this code?
List<int> li = new List<int>();
li.Add(59);
li.Add(72);
li.Add(95);
li.RemoveAt(1);
for (int x = 0; x < li.Count; x++)
  Console.Write(li[x] + " ");
*/

//59 95

//Drag and drop from the options below to define a generic method that swaps the values of its arguments and returns the value of the first argument.

static T Swap <T> 
 (ref T a, ref T b) {

  T temp = a;

  a = b;

  b = temp;

  return a;

}

//Reorder the code to declare a Queue of integers, add values 1 through 5 and print the contents of the Queue.

Queue<int> q = new Queue<int>();
for (int x = 1; x <= 5; x++)
	q.Enqueue(x);
foreach (int val in q)
Console.Write(val + " ");

//Drag and drop from the options below to define a generic class, which has a member method that returns the value of x.

class Temp <T> {

  T x;

  public T Func() {


    return x;
  }

}

/*
What is the output of this code?
List<int> a = new List<int>();
a.Add(5);
a.Add(2);
a.Add(8);
a.Reverse();
Console.Write(a[1]);
*/

//2

//Drag and drop from the options below to create a List that will contain objects of type Student.

List<Student> L = new List <Student>();

/*
What is the output of this code?
BitArray ba1 = new BitArray(4);
BitArray ba2 = new BitArray(4);            
ba1.SetAll(true);
ba2.SetAll(false);            
ba1.Set(2, false);
ba2.Set(3, true);
Console.Write(ba1.And(ba2).Get(2));
*/

//False

/*
What is the output of this code?
Stack<int> s = new Stack<int>();
s.Push(4);
s.Push(5);
s.Push(4);
s.Pop();
Console.Write(s.Peek());
*/

//5

//Fill in the blanks to declare a dictionary to map names and ages and John's, Ann's and Peter's ages. Print John's age.

Dictionary<string, int> d = 

  new Dictionary<string, int>();

d.Add("John", 24);

d.Add("Ann", 18);

d.Add("Peter", 27);

string name = "John";

Console.Write(d[name]);

// 81 Lesson

/*
Coffee Time


A coffee shop manager is running a promotion and wants to offer a discount for coffee drinks.
The program you are given takes the discount value as input and defines a dictionary, where the names of the coffee drinks are set as keys, and their prices are set as values.
Write a program to discount all of the prices and output a new price list in the format shown below.

Sample Input
10

Sample Output
Americano: 45
Latte: 63
Flat White: 54
Espresso: 54
Cappuccino: 72
Mocha: 81
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            int price = 0; 
            foreach(var element in coffee){
                price=element.Value-element.Value*discount/100;
                Console.WriteLine(element.Key + ": " + price);
            }
            


        }
    }
}