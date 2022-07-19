# 31 Lesson

#Following the DRY principle makes the code:

#easier to maintain

#How many arguments are in this function call?
#range(0, 100, 5)

#3

# 32 Lesson

#Fill in the blanks to define a function named hello:
def hello():

  print("Hi!")

#Rearrange the code to declare a function sayHi() and call it.

def sayHi():
 print("Hi!")
sayHi()

# 33 Lesson

"""
What is the result of this code?
def print_double(x):
   print(2 * x)

print_double(3)
"""

#6

#Fill in the blanks to define a function that takes two arguments and prints their multiplication.
def print_mult(x, y):

   print(x * y)

#Fill in the blanks to define a function that prints "Yes", if its parameter is an even number, and "No" otherwise.
def
 even(x):

   if x%2 == 0:

     print("Yes")

   else:

     print("No")

# 34 Lesson

#Fill in the blanks to define a function that compares the lengths of its arguments and returns the shortest one.

def shortest_string(x, y):

  if len(x) <= len(y):

    return x

  else:

    return y
    
"""
What is the highest number this function prints if called?

def print_numbers():

  print(1)

  print(2)

  return

  print(4)

  print(6)
"""

#2

# 35 Lesson

#Fill in the blank to comment out the text:

x = 8

# printing x

print(x)

#Can a docstring contain multiple lines of text?

#Yes

# 36 Lesson

"""
What is the output of this code?

def shout(word):

   return word + "!"

speak = shout

output = speak("shout")

print(output)
"""

#shout!

#Fill in the blanks to pass the function "square" as an argument to the function "test":

def square(x):

  return x * x



def test(func, x):

  print(func(x))


test(square, 42)

# 37 Lesson


"""
Which module is being used in this code?

import math

num = 10

print (math.sqrt(num))
"""

#math


#Fill in the blanks to import only the sqrt and cos functions from the math module:

from math import sqrt, cos

#What error is caused by importing an unknown module?

#ImportError

"""
What is the output of this code?

import math as m

print(math.sqrt(25))
"""

#An error occurs

# 38 Lesson

#Fill in the blanks to import the math module.

import math

#What name is given to Python's preinstalled modules?

#The Standard Library

#What does PyPI stand for?

#Python Package Index

# 39 Lesson

#Fill in the blanks to define a function that takes two numbers as arguments and returns the smaller one.

def min(x, y):

  if x<=y:


    return x

  else:

    return y


#Rearrange the code to define a function that calculates the sum of all numbers from 0 to its argument.

def sum(x):
 res = 0
 for i in range(x):
  res += i
 return res

#How would you refer to the randint function if it was imported like this?

#from random import randint as rnd_int

#rnd_int

"""
What is the highest number output by this code?

def print_nums(x):

  for i in range(x):

    print(i)

    return

print_nums(10)
"""
#0

"""
What is the output of this code?

def func(x):

  res = 0

  for i in range(x):

     res += i

  return res



print(func(4))
"""

#6

# 40 Lesson
"""
Celsius to Fahrenheit


You are making a Celsius to Fahrenheit converter.
Write a function to take the Celsius value as an argument and return the corresponding Fahrenheit value.

Sample Input
36

Sample Output
96.8 
"""

celsius = int(input())

def conv(c):
    return 9/5 * c + 32
    

fahrenheit = conv(celsius)
print(fahrenheit)