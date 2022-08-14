# 63 Lesson

"""
What is the output of this code?
def test(func, arg):
  return func(func(arg))

def mult(x):
  return x * x

print(test(mult, 2))
"""

#16

"""
Is this a pure function?
def func(x):
  y = x**2
  z = x + y
  return z
"""

#Yes

#Which of these is not an advantage of using pure functions?

#They are easier to write

# 64 Lesson

#What are anonymous functions called?

#lambdas

#Fill in the blanks to create a lambda function that returns the square of its argument, and call it for the number 8.

a = (lambda x: x*x) (8)

"""
What is the result of this code?
triple = lambda x: x * 3
add = lambda x, y: x + y
print(add(triple(3), 4))
"""

#13

# 65 Lesson

#Fill in the blanks to multiply each item in the list by 2 using lambda syntax.

nums = [11, 22, 33]

a = list(map(lambda x: x*2, nums))

#Fill in the blanks to extract all items that are less than 5 from the list.
nums = [1, 2, 5, 8, 3, 0, 7]

res = list(
filter(lambda x: x<5, nums))

print(res)

# 66 Lesson

#What statement is used in functions to turn them into generators?

#yield

#Fill in the blanks to create a prime number generator, that yields all prime numbers in a loop. (Consider having an is_prime function already defined):

def get_primes():

  num = 2

  while True:

    if is_prime(num):

      yield
 num

    num += 1

"""
What is the result of this code?
def make_word():
  word = ""
  for ch in "spam":
    word +=ch
    yield word

print(list(make_word()))
"""

#['s', 'sp', 'spa', 'spam']

# 67 Lesson

#What are decorators?

#Functions that modify other functions

#Which statement can be used to achieve the same behavior as my_func = my_dec(my_func)?

#@my_dec

# 68 Lesson

#What is the base case of a recursive function?

#A case that doesn't involve any further calls to that function

"""
What is the result of this code?
def sum_to(x):
   return x + sum_to(x-1)
print (sum_to(5))
"""

#RuntimeError

"""
What is the result of this code?
def fib(x):
  if x == 0 or x == 1:
    return 1
  else: 
    return fib(x-1) + fib(x-2)
print(fib(4))
"""

#5

# 69 Lesson

"""
What is the output of this code?
letters = {"a", "b", "c", "d"}
if "e" not in letters:
  print(1)
else: 
  print(2)
"""

#1

#Fill in the blanks to create a set, add the letter "z" to it, and print its length.
nums = {"a", "b", "c", "d"}

nums.add("z")

print(len(nums))

"""
What is the output of this code?
a = {1, 2, 3}
b = {0, 3, 4, 5}
print(a & b)
"""

#{3}

#Which of the following data types does not allow duplicate values?

#Sets

# 70 Lesson

#Fill in the blanks to import the cycle function from the itertools module.

from itertools import cycle

#Fill in the blanks to take the numbers from the list while they are even, using the takewhile function.

from itertools import takewhile

nums = [2, 4, 6, 7, 9, 8]

a = takewhile(lambda x: x%2==0, nums)

print(list(a))

"""
What is the output of this code?
from itertools import product
a={1, 2}
print(len(list(product(range(3), a))))
"""

#6

# 71 Lesson

"""
What is the result of this code?
nums = {1, 2, 3, 4, 5, 6}
nums = {0, 1, 2, 3} & nums
nums = filter(lambda x: x > 1, nums)
print(len(list(nums)))
"""

#2

"""
What is the result of this code?
def power(x, y):
  if y == 0:
    return 1
  else:
    return x * power(x, y-1)
		
print(power(2, 3))
"""

#8

#Fill in the blanks to calculate the expression x*(x+1) using an anonymous function and call it for the number 6.

a = (lambda x: x*(x+1)) (6)

print(a)

#Fill in the blanks to leave only even numbers in the list.
nums = [1, 2, 8, 3, 7]

res = list(filter(lambda x: x%2==0, nums))

print(res)

#Drag and drop from the options below to print only the items in the set "a" that are not in the set "b".
print( a - b )

# 72 Lesson

"""
Fibonacci


The Fibonacci sequence is one of the most famous formulas in mathematics.
Each number in the sequence is the sum of the two numbers that precede it.
For example, here is the Fibonacci sequence for 10 numbers, starting from 0: 0,1,1,2,3,5,8,13,21,34.

Write a program to take N (variable num in code template) positive numbers as input, and recursively calculate and output the first N numbers of the Fibonacci sequence (starting from 0).

Sample Input
6

Sample Output
0
1
1
2
3
5
"""

num = int(input())


def fibonacci(n):

	if n<=1:
		return n
	else:
		return fibonacci(n-2) + fibonacci(n-1)


for a in range(num):
    print(fibonacci(a))