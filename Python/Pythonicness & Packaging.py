# 92 Lesson

#Which module prints the Zen of Python when imported?

import this

#Which of these principles does not appear in the Zen of Python?

#Use recursion where possible

# 93 Lesson

#Which choice is PEP 8-compliant as the name of a class?

#MyClassName

#What is the recommended length limit for a line of code?

#80

# 94 Lesson

#How is *args accessed inside a function?

#As the tuple args

#What is wrong with this function definition?
#def function(x, y=7, z, *argums):

#A non-default argument follows a default argument

#What kind of object is kwargs?

#A dictionary

# 95 Lesson

"""
What is the value of y after this code runs?
x, y = [1, 2]
x, y = y, x
"""

#1

"""
What is the output of this code?
a, b, c, d, *e, f, g = range(20)
print(len(e))
"""

#14

# 96 Lesson

"""
What is the value of b?
b = 1 if 2+2 == 5 else 2
"""

#2

# 97 Lesson

"""
What is the largest number this code prints?
for i in range(10):
   if i > 5:
      print(i)
      break
else:
   print("7")
"""

#6

"""
What is the sum of the numbers printed by this code?
try:
  print(1)
  print(1 + "1" == 2)
  print(2)
except TypeError:
  print(3)
else:
  print(4)
"""

#4

# 98 Lesson

"""
Which variable couldn't be accessed if this code was imported as a module?
x = 1
y = x
if __name__=="__main__":
    z = 3
"""

#z

#Rearrange the code to print "Welcome" if the script is imported, and "Hi" if it is not imported.

if __name__=="__main__":
 print("Hi")
else:
 print("Welcome")

# 99 Lesson

#Which of these is a web framework?

#Django

#Is it possible to use Python on its own to develop games?

#Yes

# 100 Lesson

#Which file is placed in a directory to make it a package?

#__init__.py

#What is the command used for building a source distribution?

#python setup.py sdist

# 101 Lesson

#Which of these does not convert Python scripts to Windows executables?

#PyExecutable

# 102 Lesson

#Which of these isn't a file used in creating a package?

#__py2exe__.py

#What is PEP 8?

#Guidelines for writing code

"""
What is the output of this code?
def func(**kwargs):
  print(kwargs["zero"])

func(a = 0, zero = 8)
"""

#8

"""
What is sum of the numbers printed by this code?
for i in range(10):
  try: 
    if 10 / i == 2.0:
      break
  except ZeroDivisionError:
    print(1)
  else:
    print(2)
"""

#9

#Fill in the blanks to swap the variable values with one single statement.

a = 7

b = 42

a, b = b, a


# 103 Lesson

"""
Adding Words


You need to write a function that takes multiple words as its argument and returns a concatenated version of those words separated by dashes (-).
The function should be able to take a varying number of words as the argument.

Sample Input
this
is
great

Sample Output
this-is-great
"""

def concatenate(*args):
    result=""
    for i in args:
        if result=="":
            result+=i
        else:
            result+="-"+i
        

    return result

print(concatenate("I", "love", "Python", "!"))