# 52 Lesson

#What is "None" often used to represent?

#Absence of a value

"""
What number does this code print?

foo = print()

if foo == None:

   print(1)

else:

   print(2)

"""

#1

# 53 Lesson

#Fill in the blanks to define a valid dictionary with two elements.

cars = {"BMW": "blue", "Volvo": "red"}

"""
What is the result of this code?

test = { }

print(test[0])
"""

#KeyError

#Which of these values can't be used as a dictionary key?

{2: 4, 3: 9, 4: 16,}

# 54 Lesson

"""
What is the result of this code?

primes = {1: 2, 2: 3, 4: 7, 7:17}

print(primes[primes[4]])

"""

#17

#Drag and drop from the options below to print "Yes", if the key 112 is present in the dictionary named "pairs".

if 112 in pairs:

  print("Yes")

"""
What is the result of this code?

fib = {1: 1, 2: 1, 3: 2, 4: 3}

print(fib.get(4, 0) + fib.get(7, 5))
"""

#8

# 55 Lesson

#Fill in the blanks to create a list, dictionary, and tuple:

# list

list = ["one", "two"]

# dictionary 

dict = {1:"one", 2:"two"}

# tuple 

tp = ("one", "two")

"""
What is the result of this code?

tuple = (1, (1, 2, 3))

print(tuple[1])
"""

#(1, 2, 3)

# 56 Lesson

#What is the result of this code?

sqs = [0, 1, 4, 9, 16, 25, 36, 49, 64]

#[16, 25, 36]

#Fill in the blanks to take the first two elements of the list:

list = ["a", "b", "c", "d"]

a = list[0:2]

"""
What is the output of this code?

sqs = [0, 1, 4, 9, 16, 25, 36, 49, 64, 81]

print(sqs[1::4])
"""

#[1, 25, 81]

"""
What is the output of this code?

sqs = [0, 1, 4, 9, 16, 25, 36, 49, 64, 81]

print(sqs[7:5:-1])
"""

#[49, 36]

# 57 Lesson

"""
What does this list comprehension create?

nums = [i*2 for i in range(10)]
"""

#A list of even numbers between 0 and 18

#Create a list of multiples of 3 from 0 to 20.

a = [i for i in range(20) if i%3==0]

#Fill in the blanks to create a list of numbers multiplied by 10 in the range of 5 to 9.

a = [x*10 for x in range(5, 9)]

# 58 Lesson

#What is the result of this code?
print("{0}{1}{0}".format("abra", "cad"))

#abracadabra

"""
What is the result of this code?
str="{c}, {b}, {a}".format(a=5, b=9, c=7)
print(str)
"""

#7, 9, 5

# 59 Lesson

#Fill in the blanks to turn the string uppercase.

a = "Spam"

b = a.upper()

"""
What is the result of this code?
a=min([sum([11, 22]), max(abs(-30), 2)])
print(a)
"""

#30

"""
What is the result of this code?
nums = [-1, 2, -3, 4, -5]
if all([abs(i) < 3 for i in nums]):
  print(1)
else:
  print(2)
"""

#2

# 60 Lesson

#Fill in the blanks to read the contents of a file using the "with" statement.
with open(filename) as f:

   text = f.read()

#Why has the character-counting code been put in a function?

#So it can be run multiple times

#What is the purpose of the round function in the code?

#To reduce the number of digits printed

# 61 Lesson

#Can you slice a tuple?

#Yes

#Which list slicing reverses the list 'numbers'?

#numbers[::-1]

#What could be described as an immutable list?

#A tuple

#What is returned by functions that don't have a return statement?

#None

"""
What is the result of this code?
nums = (55, 44, 33, 22)
print(max(min(nums[:2]), abs(-42)))
"""

#44

# 62 Lesson

"""
Longest Word


Given a text as input, find and output the longest word.

Sample Input
this is an awesome text

Sample Output
awesome
"""

txt = input()
split=txt.split()
lenght=0

for i in split:
  if len(i)>lenght:
      lenght=len(i)
      word=i
      
print(word)