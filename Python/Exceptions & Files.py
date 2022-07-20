# 41 Lesson

#What is an exception?

#An event that occurs due to incorrect code or input

#Which exception is raised by this code?

#print("7" + 4)

#TypeError

# 42 Lesson

"""
What is the output of this code?

try:

  variable = 10

  print (10 / 2)

except ZeroDivisionError:

  print("Error")

print("Finished")
"""

#5.0 Finished

"""
What is the output of this code?

try:

  meaning = 42

  print(meaning / 0)

  print("the meaning of life")

except (ValueError, TypeError):

  print("ValueError or TypeError occurred")

except ZeroDivisionError:

  print("Divided by zero")
"""

#Divided by zero

#Fill in the blanks to handle all possible exceptions.

 try:
  num1 = input(":")

  num2 = input(":")

  print(float(num1)/float(num2))

 except:
  print("Invalid input")

# 43 Lesson

"""
What is the output of this code?

try:

  print(1)

except:

  print(2)

finally:

  print(3)
"""

#1 3

#Drag and drop from the options below to create a try/except/finally block.

try:

  print(1)

except:

  print(2)

finally:

  print(42)

# 44 Lesson

"""
Which errors occur during the execution of this code?

try:

  print(1 / 0)

except ZeroDivisionError:

  raise ValueError
"""

#ZeroDivisionError and ValueError

#Fill in the blanks to raise a ValueError exception, if the input is negative.

num = input(":")

if float(num) < 0:

  raise ValueError("Negative!")

#Can you use the raise statement outside the except block?

#Yes

# 45 Lesson

"""
What is the highest number printed by this code?

print(0)

assert "h" != "w"

print (1)

assert False

print(2)

assert True

print(3)
"""

#1

#Fill in the blanks to define a function that takes one argument. Assert the argument to be positive.

def my_func(x):

  assert x > 0, "Error!"

  print(x)

# 46 Lesson

#Which function is used to access files?

#open

#Drag and drop from the options below to open a file called "test.bin" in binary read mode.

file = open("test.bin", "rb")

#How would you close a file stored in a variable "text_file"?

#text_file.close()

# 47 Lesson

#Rearrange the code to open a file, read its contents, print them, and then close the file.

file = open("test.txt")
cont = file.read()
print(cont)
file.close()

"""
How many characters would be in each line printed by this code, if one character is one byte?

file = open("filename.txt", "r")

for i in range(21):

  print(file.read(4))

file.close()
"""

#4

#Fill in the blanks to open a file, read its content and print its length.

file = open("filename.txt", "r")

str = file.read()

print(len(str))

file.close()

"""
If the file test.txt has 7 lines of content, what will the following expression return?

len(open("test.txt").readlines())
"""

#7

# 48 Lesson

#Which line of code writes "Hello world!" to a file?

#file.write("Hello world!")

#What happens if you open a file in write mode and then immediately close it?

#The file contents are deleted

#If a file write operation is successful, which one of these statements will be true?

#file.write(msg) == len(msg)

# 49 Lesson

"""
Will the close() function get called in this code?

try:

  f = open("filename.txt")

  print(f.read())

  print(1 / 0)

finally:

  f.close()
"""

#Yes

#Fill in the blanks to create a valid with statement, reading the contents of the file.

with open("test.txt") as f:

  print(f.read())

# 50 Lesson

"""
Which number is not printed by this code?

try:

  print(1)

  print(20 / 0)

  print(2)

except ZeroDivisionError:

  print(3)

finally:

  print(4)
"""

#2

#Open the file in binary write mode.

open("test.txt", "wb")

#Fill in the blanks to try to open and read from a file. Print an error message in case of an exception.

try:

  
 with open("test.txt") as f:

    print(f.read())

except:

  print("Error")

"""
What is the highest number that would be printed by this code?

try:

  print(1)

  assert 2 + 2 == 5

except AssertionError:

  print(3)

except:

  print(4)
"""

#3

# 51 Lesson

"""
Book Titles


You have been asked to make a special book categorization program, which assigns each book a special code based on its title.
The code is equal to the first letter of the book, followed by the number of characters in the title.
For example, for the book "Harry Potter", the code would be: H12, as it contains 12 characters (including the space).

You are provided a books.txt file, which includes the book titles, each one written on a separate line.
Read the title one by one and output the code for each book on a separate line.

For example, if the books.txt file contains:
Some book
Another book

Your program should output:
S9
A12 
"""

file = open("/usercode/files/books.txt", "r")

list=file.readlines()

for i in list:
    letter=str(i[0])
    number=str(len(i)- i.count('\n'))
    print(letter+number)
  

file.close()