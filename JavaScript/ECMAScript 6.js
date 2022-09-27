// 55 Lesson

//JavaScript and ES6 are different technologies for different purposes.

//False

// 56 Lesson

/*
What is the output of this code?
function letItBe() {
  let v = 2;
  if (true) {
    let v = 4;  
    console.log(v); 
  }
  console.log(v); 
}
letItBe();
*/

//4 2

//Fill in the blanks to make a constant named total and the variable i that is only accessible inside the loop.

const total = 100;

let sum = 0;

for(let i = 0; i < total; i++) {

  sum += i;

}

//Fill in the blanks to output "We are learning ES6!".

let n = 6;

let s = 'ES';

let msg = `We are learning ${s + n}!`;

console.log(msg);

// 57 Lesson

//Fill in the blanks to iterate through all the characters using the for...of loop.

for (let ch of "SoloLearn") {

  console.log(ch);

}

//Fill in the blanks to declare an arrow function that takes an array and prints the odd elements.

const printOdds = (arr) => {

  arr.forEach(el => {

    if (el % 2 != 0) console.log(el);

  });

}

/*
What is the output of this code?
function magic(a, b = 40) {
  return a + b;
}
console.log(magic(2));
*/

//42


// 58 Lesson

//Fill in the blanks to make this code run and print 60.

let car = {

  speed: 40,

  accelerate() {

    this.speed += 10;

  }

};

car.accelerate();

car.accelerate();

console.log(car.speed);

//Fill in the blanks to create an object with its properties.

let prop = 'foo';

let o = {

  [prop]: 'lol',

  ['b' + 'ar']: '123'

};

/*
What is the output of this code?
const obj1 = {
  a: 0,
  b: 2,
  c: 4
};
const obj2 = Object.assign({c: 5, d: 6}, obj1);
console.log(obj2.c, obj2.d);
*/

//46


// 59 Lesson

/*
What is the output of the following code?
let names = ['John', 'Fred', 'Ann'];
let [Ann, Fred, John] = names;
console.log(John);
*/

//Ann

/*
What is the output of the following code?
const obj = {one: 1, two: 2};
let {one:first, two:second} = obj;
console.log(one);
*/

//Error

// 60 Lesson

/*
What is the output of the following code?
function magic(...nums) {
  let sum = 0;
  nums.filter(n => n % 2 == 0).map(el => sum+= el);
  return sum;
}
console.log(magic(1, 2, 3, 4, 5, 6));
*/

//12

/*
What is the output of the following code?
let nums = [3, 4, 5];
let all = [1, 2, ...nums, 6];
console.log(all[3]);
*/

//4


// 61 Lesson

//Fill in the blanks to declare a class Point with a constructor initializing its x and y members.

class
 Point {

  constructor(a, b) {

    this.x = a;

    this.y = b;

  }



  getX() { return this.x; }

  getY() { return this.y; }

}

//Fill in the blanks to output "Rex barks."

class Dog {

  constructor(name) {

    this.name = name;

  }

  bark() {

    console.log(this.name+ ' barks.');

  }

}

let d = new Dog('Rex');

d.bark();

//Fill in the blanks to declare a class Student which inherits from the Human class.

class Human {

  constructor(name) {

    this.name = name;

  }

}



class Student extends Human {

  constructor(name, age) {

    super(name);

    this.age = age;

  }

}


// 62 Lesson

/*
What is the output of this code?
const map = new Map();
map.set('one', 1);
map.set('2', 'two');
if (map.has('two')) {
  console.log('two');
} else {
  console.log(map.get('one'));
}
*/

//1

//Fill in the blanks to create and output a set with the values 1, 2, 3.

const set = new Set();

set.add(1).add(2).add(3);

for(let v of set.values())

  console.log(v);


// 63 Lesson

//Fill in the blanks to define a function that returns a Promise object.

function foo() {

  return new Promise((resolve, reject) => {

    let result = getSomeResult();

    if (result)

      resolve('Success');

    else

      reject('Something went wrong');

  });

}

//You can exit and re-enter generator functions, and their variable bindings will be saved across re-entrances.

//True

/*
Fill in the blanks to import the following from "util/calc.js":
export const hit = (x, y, z) => {
  return x * y + z / 2;
}
export const degree = 50;
*/

import * as calc from "util/calc";

calc.hit(1, 2, calc.degree);

/*
What is the output of this code?
const arr = ['3', '5', '8'];
console.log(
  arr.find(x => x == 8).repeat(2)
);
*/

//88

// 64 Lesson

//Which of the following is not one of the new ES6 features?

//Hoisting

//Fill in the blanks to declare a constant num and an arrow function calc.

const num = 5;

const calc = (x, y, z = num) => {

  return x + y + z;
 }

//Fill in blanks to make the variable arr3 look like the following: [1, 2, 3, 4, 5, 6, 7, 8].

const arr1 = [1, 2, 3];

const arr2 = [5, 6, 7, 8];

let arr3 = [...arr1, 4, ...arr2];

/*
What is the output of the following code?
const arr1 = [1, 2, 3, 4, 5];
const arr2 = [...arr1, 6];
const func = (...rest) => {
  console.log(rest.length);
}
func(...arr1);
func(...arr2);
*/

//5 6

/*
What is the output of this code?
const square = num => num * num;
console.log(square(6) + 6);
*/

//42

//Fill in the blanks to copy the user object to the newUser object by destructuring the name and age properties. Pass the value 9999 for the id property.
const user = {

  name: 'David',

  age: 28,

  id: 1234

};

let newUser = Object.assign({},

  {name, age} = user,

  {id: 9999});

console.log(newUser);

/*
Fill in the blanks to get the following output:
zero = 0
one = 1
*/

let myMap = new Map();

myMap.set('zero', 0);

myMap.set('one', 1);

for (let [key, value] of myMap) {

  console.log(`${key} = ${value}`);

}

// 65 Lesson

/*

Words


You are making a text encryptor. It should take multiple words and output a combined version, where each word is separated by a dollar sign $.
For example, for the words "hello", "how", "are", "you", the output should be "$hello$how$are$you$".
The given code declares a class named Add, with a constructor that takes one rest parameter.
Complete the code by adding a print() method to the class, which should generate the requested output.

*/

class Add {
  constructor(...words) {
      this.words = words;
  }
  get print(){
    return this.combined;
  }
  combined(){
    for(let element in this.words){
      console.log("$"+this.words[element])
    }
    console.log("$")
  }
}

var x = new Add("hehe", "hoho", "haha", "hihi", "huhu");
var y = new Add("this", "is", "awesome");
var z = new Add("lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing", "elit");
x.print();
y.print();
z.print();