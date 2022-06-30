# 18 Lesson

#What are the two Boolean values in Python?

#True and False

"""
What is the output of this code?

print(7 != 8)
"""

#True

"""
What is the output of this code?

print( 7 > 7.0 )
"""

#False

"""
What is the output of this code?

print( 8.7 <= 8.70 )
"""

#True

# 19 Lesson

#What part of an if statement should be indented?

#The statements within it

"""
What is the output of this code?

spam = 7
if spam > 5:
   print("five")
if spam > 8:
   print("eight")
"""

#five

"""
What is the output of this code?

num = 7
if num > 3:
   print("3")
   if num < 5:
      print("5")
      if num ==7:
         print("7")
"""

#3

# 20 Lesson

"""
What is the result of this code?

if 1 + 1 == 2:
   if 2 * 2 == 8:
      print("if")
   else:
      print("else")
"""

#else

#Fill in the blanks to compare the variables and output the corresponding text:
x = 10

y = 20

if x > y:


   print("if statement")

else:

   print("else statement")
   
#A shorter option for an "else if" statement is:

#elif  

# 21 Lesson

"""
What is the result of this code?

if (1 == 1) and (2 + 2 > 3):
  print("true")
else:
  print("false")
"""

#true

#Fill in the blanks to print "Welcome".
age = 15

money = 500

if age > 18 or money > 100:
 
   print("Welcome")

#What is the result of this code?

if not True:
   print("1")
elif not (1 + 1 == 3):
   print("2")
else:
   print("3")

#2

# 22 Lesson

"""
What is the result of this code?

if 1 + 1 * 3 == 6:
   print("Yes")
else:
   print("No")
"""

#No

"""
What is the result of this code?

x = 4
y = 2
if not 1 + 1 == y or x == 4 and 7 == 8:
  print("Yes")
elif x > y:
  print("No")
"""

#No

# 23 Lesson

"""
What is the result of this code?

nums = [5, 4, 3, 2, 1]
print(nums[1])
"""

#4

"""
How many items are in this list?

[2,]
"""

#1

#Fill in the blanks to create a list and print its 3rd element.
list = [42, 55, 67]

print(list[2])

"""
Which line of code will cause an error?

num = [5, 4, 3, [2], 1]
print(num[0])
print(num[3][0])
print(num[5])
"""

#Line 4

# 24 Lesson

"""
What is the result of this code?

nums = [1, 2, 3, 4, 5]
nums[3] = nums[1]
print(nums[3])
"""

#2

#Fill in the blanks to create a list, reassign its 2nd element and print the whole list.
nums = [33, 42, 56]

nums[1] = 22

print(nums)

"""
What is the result of this code?

nums = [10, 9, 8, 7, 6, 5]
nums[0] = nums[1] - 5
if 4 in nums:
  print(nums[3])
else:
  print(nums[4])
"""

#7

#Fill in the blanks to print "Yes" if the list contains 'z':
letters = ['a', 'b', 'z']

if "z" in letters:

  print("Yes")

# 25 Lesson

"""
What is the result of this code?

words = ["hello"]
words.append("world")
print(words[1])
"""

#world

"""
What is the result of this code?

letters = ["a", "b", "c"]
letters.append("d")
print(len(letters))
"""

#4

"""
What is the result of this code?

nums = [9, 8, 7, 6, 5]
nums.append(4)
nums.insert(2, 11)
print(len(nums))
"""

#7

#Drag and drop from the options below to add 'z' to the end of the list and print the list's length.
list.append('z')

print(len (list) )

# 26 Lesson

"""
How many numbers does this code print?

i = 3
while i>=0:
   print(i)
   i = i - 1
"""

#4

#Fill in the blanks to create a loop that increments the value of x by 2 and prints the even values.
x = 0

while x <=20:
  print(x)

  x += 2

"""
How many numbers does this code print?

i = 5
while True:
  print(i)
  i = i - 1
  if i <= 2:
    break
"""

#3

#Which statement ends the current iteration and continues with the next one?

#continue

# 27 Lesson

#Fill in the blanks to create a valid for loop.
letters = ['a', 'b', 'c']

for l in letters:

  print(l)

"""
What is the output of this code?

list = [2, 3, 4, 5, 6, 7]

for x in list:
    if(x%2==1 and x>4):
        print(x)
        break
"""

#5

#Which construct can be used to iterate through a list?

#Loops

# 28 Lesson

"""
What is the result of this code?

nums = list(range(5))
print(nums[4])
"""

#4

"""
What is the result of this code?

nums = list(range(5, 8))
print(len(nums))
"""

#3

"""
What is the result of this code?
nums = list(range(3, 15, 3))
print(nums[2])
"""

#9

#Fill in the blanks to create a for loop that prints only the even values in the range:
for
 i in range(0, 20, 2):

  print(i)

# 29 Lesson

"""
What is the output of this code?

list = [1, 1, 2, 3, 5, 8, 13]
print(list[list[4]])
"""

#8

"""
What does this code do?

for i in range(10):
  if not i % 2 == 0:
    print(i+1)
"""

#Print all the even numbers between 2 and 10

"""
How many lines will this code print?

while False:
  print("Looping...")
"""

#0

#Fill in the blanks to print the first element of the list, if it contains even number of elements.
list = [1, 2, 3, 4]

if len(list) % 2 == 0:

  print(list[0])
  
"""
What does this code output?

letters = ['x', 'y', 'z']
letters.insert(1, 'w')
print(letters[2])
"""

#y

#Fill in the blanks to iterate over the list using a for loop and print its values.
list = [1, 2, 3]

for var in list:

  print(var)

# 30 Lesson

"""
FizzBuzz is a well known programming assignment, asked during interviews.

The given code solves the FizzBuzz problem and uses the words "Solo" and "Learn" instead of "Fizz" and "Buzz".
It takes an input n and outputs the numbers from 1 to n.
For each multiple of 3, print "Solo" instead of the number.
For each multiple of 5, prints "Learn" instead of the number.
For numbers which are multiples of both 3 and 5, output "SoloLearn".

You need to change the code to skip the even numbers, so that the logic only applies to odd numbers in the range.
"""
n = int(input())

for x in range(1, n):
    if x % 2 == 0:
        continue
    elif x % 3 == 0 and x % 5 == 0:
        print("SoloLearn")
    elif x % 3 == 0:
        print("Solo")
    elif x % 5 == 0:
        print("Learn")
    else:
        print(x)