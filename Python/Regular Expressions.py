# 83 Lesson

#Which of the following tasks CANNOT be performed using regular expressions?

#Checking whether an email address is real

#Which of these patterns would not re.match the string "spamspamspam"?

#pamspam

#Which of these is not a function in the re module?

#findlist

#Drag and drop from the options below to print the starting and ending positions of the match.

import re

pattern = r"test"

match = re.search(pattern, "some test")

print(match.start())

print(match.end())

#Fill in the blanks to replace all 9s in the string with 0s.

import re

num = "07987549836"

pattern = r"9"

num = re.sub(pattern, "0", num)

print(num)

# 84 Lesson

#Fill in the blanks to create a raw string.

str = r"I am \r\a\w!"

#What would '....' match?

#Any four character string with no newlines

#Fill in the blanks to create a pattern that matches strings that contain 3 characters, out of which the last character is an exclamation mark.

#r"..!$"

# 85 Lesson

#What would [abc][def] match?

#Any letter out of "abc", then any out of "def"

#What would [1-5][0-9] match?

#Any two-digit number from 10 to 59

#Fill in the blanks to match strings that are not entirely composed of digits.

import re

pattern = r"[^0-9]"
m = re.search(pattern, "Hi there!")

# 86 Lesson

#What would [a^]* match?

#Zero or more repetitions of "a" or "^"

#Fill in the blanks to create a pattern that matches strings that contain one or more 42s.

r"(42)+$"

#Fill in the blanks to match both 'color' and 'colour'.

pattern = r"colo(u)?r"

#Which of these is the same as the metacharacter '+'?

#{1,}

# 87 Lesson

#What would '([^aeiou][aeiou][^aeiou])+' match?

#One or more repetitions of a non-vowel, a vowel and a non-vowel

#What would group(3) be of a match of 1(23)(4(56)78)9(0)?

#56

#What would be the result of len(match.groups()) of a match of (a)(b(?:c)(d)(?:e))?

#3

#What regex is not equivalent to the others?

#[1-6]

# 88 Lesson

#What would (abc|xyz)\1 match?

#"abc" or "xyz", followed by the same thing

#Which pattern would NOT match "123!456!"?

#(\D+\s?)+

#Which pattern would match 'SPAM!' in a search?

#\AS...\b.\Z

# 89 Lesson

#Which of these must be done with regular expressions, rather than string methods?

#Checking to see if a string contains a date

#In our example, why is the dot character preceded by a backslash?

#to treat it as a character

# 90 Lesson

#Which of these metacharacters isn't to do with repetition?

#\

#How many groups are in the regex (ab)(c(d(e)f))(g)?

#5

#Which regex would match "email@domain.com"?

#\w+@domain.com

#Which string would be matched by "[01]+0$"?

#10101111001010

#What would be matched by "(4{5,6})\1"?

#10 or 12 fours

# 91 Lesson

"""
Phone Number Validator


You are given a number input, and need to check if it is a valid phone number.
A valid phone number has exactly 8 digits and starts with 1, 8 or 9.
Output "Valid" if the number is valid and "Invalid", if it is not.

Sample Input
81239870

Sample Output
Valid
You can use a regu
"""

import re
input=input()
pattern= r"[189][0-9]{7}$"
if re.search(pattern,input):
    print("Valid")
else:
    print("Invalid")
