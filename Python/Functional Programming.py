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

# 67 Lesson

# 68 Lesson

# 69 Lesson

# 70 Lesson

# 71 Lesson

# 72 Lesson