# 73 Lesson

#What type of object is a method?

#Function

#Fill in the blanks to create a class and its constructor, taking one argument and assigning it to the "name" attribute. Then create an object of the class.

class
 Student:

  def __init__(self, name):

    self.name = name

test = Student("Bob")

#Fill in the blanks to create a class with a method sayHi().

class Student:

  def __init__(self, name):

    self.name = name

  def
 sayHi(self):

    print("Hi from "+self.name)

s1 = Student("Amy")

s1.sayHi()

#What error is caused by trying to access unknown attributes?

#AttributeError

# 74 Lesson

#Which piece of code shows a new class Spam inheriting from Egg?

#class Spam(Egg):

"""
What is the result of this code?
class A:
  def method(self):
    print(1)

class B(A):
  def method(self):
    print(2)

B().method()
"""

#2

"""
What is the result of this code?
class A:
  def a(self):
    print(1)
class B(A):
  def a(self):
    print(2)
	
class C(B):
  def c(self):
    print(3)
		
c = C()
c.a()
"""

#2

#What is the superclass of a class?

#The class it inherits from

# 75 Lesson

#What is the magic method for creating an instance?

__init__

#What is A() ^ B() evaluated as, if A doesn't implement any magic methods?

#B().__rxor__(A())

#What is __le__ a magic method for?

#x <= y

#Which magic method call is made by x[y] = z?

#x.__setitem__(y, z)

# 76 Lesson

#Which stage corresponds to the __init__ method being called?

#instantiation

#What is __del__ the magic method for?

#del instance

# 77 Lesson

#What is a private method in Python?

#A method external code is discouraged from using

#What is the purpose of prefacing a method name with a single underscore?

#To mark it as private

#How would the attribute __a of the class b be accessed from outside the class?

_b__a

# 78 Lesson

#Fill in the blanks to make sayHi() a class method.

class Person:

  def __init__(self, name):

    self.name = name

  @classmethod
  def
 sayHi(cls):

    print("Hi")

#Which of these is most likely to be a static method?

#def spam(x, y):

# 79 Lesson

#Fill in the blanks to create an "isAdult" property.

class Person:

  def __init__(self, age):

    self.age = int(age)

  @property

  def isAdult(self):

    if self.age > 18:

      return True

    else:

      return False

#Define a decorator that would be used to add a setter to the property egg.

@egg.setter

# 80 Lesson

#What does the split method called on the input do?

#Divides the input into separate words

#Why does Goblin inherit from GameObject?

#Goblin is a kind of GameObject

#Why was desc turned into a property?

#So it could be dynamically created when accessed

# 81 Lesson

#How is a property created?

#Using the property decorator

#What is the difference between a class method and a static method?

#Class methods are passed the calling class, static methods aren't

#What are the usual parameter names for the calling instance and the calling class?

#self and cls

#What method is called just before an object is instantiated?

#__init__

#Fill in the blanks to make the egg attribute strongly private and access it from outside of the class.

class Test:

  __egg = 7

t = Test()

print(t._Test__egg)

#What is the automatic process by which unnecessary objects are deleted to free memory?

#Garbage collection

#Fill in the blanks to make a setter for the property name.

class Person:

  def __init__(self, name):

    self._name = name

  @property

  def name(self):

    return self._name

  @name.setter

  def name(self, value):

    self._name = value

# 82 Lesson

"""
Juice Maker


You are given a Juice class, which has name and capacity properties.
You need to complete the code to enable and adding of two Juice objects, resulting in a new Juice object with the combined capacity and names of the two juices being added.

For example, if you add an Orange juice with 1.0 capacity and an Apple juice with 2.5 capacity, the resulting juice should have:
name: Orange&Apple
capacity: 3.5

The names have been combined using an & symbol.
Use the __add__ method to define a custom behav
"""

class Juice:
    def __init__(self, name, capacity):
        self.name = name
        self.capacity = capacity

    def __str__(self):
        return (self.name + ' ('+str(self.capacity)+'L)')
    
    def __add__(self,other):

        return Juice(self.name + "&" + other.name ,self.capacity + other.capacity)


a = Juice('Orange', 1.5)
b = Juice('Apple', 2.0)

result = a + b
print(result)