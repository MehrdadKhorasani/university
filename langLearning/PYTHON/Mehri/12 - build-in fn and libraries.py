##### some of build-in functions:

# min & max
print(max([10,50,4,8,-10])) # 50
print(min([10,50,4,8,-10])) # -10

# sum
print(sum([10,50,4,8,-10])) # 62

#pow
print(pow(2,3)) #8

# eval
print(10+20-5*(2+10/3)) #3.3333333333333286
str1 = "10+20-5*(2+10/3)"
print(str1) #10+20-5*(2+10/3)
print(eval(str1)) #3.3333333333333286

# len
print(len("this string has so many letters")) # 31

#chr & ord
print(chr(65)) # A
print(chr(97)) # a
print(ord("A")) # 65
print(ord("a")) # 97

# all & any
a = [1,5,8,True]
b = [10,9,7,3]
c = [1,5,8,0]
print(all(a)) # True
print(all(c)) # 0 is falsy value
print(any(c)) # True

# abs
print(abs(-15)) # 15



##### some of libraries (modules):

### some of function of random library:
import random as r
print(r.random().__round__(2))
print(r.randint(10,50))
print(r.randrange(1,30,4))
newList = [10,9,7,3]
print(r.choice(newList))
print(r.choices(newList))
print(round(2.358799456)) # 2
print(round(2.358799456,3)) #2.359
# newerList = r.shuffle(newList)
# print(newerList)
print(r.sample(newList,2))

### some of function of math library:
# from math import pi,pow,sqrt
from math import *
print(pow(10,2)) # 100.0
print(sqrt(81)) # 9
print(pi) # 3.141592653589793
print(round(pi,3)) # 3.142
print(abs(-165)) # 165
print(factorial(5)) # 120
print(ceil(2.44)) # 3
print(floor(2.44)) # 2
print(fmod(10.5,3)) # 1.5 # 
print(inf) # inf
print(log(8,2)) # 3.0
print(log(27,3)) # 3.0
print(log10(100)) # 2.0
print(sin(90*pi/180)) # 1.0
print(sin(radians(90))) # 1.0
print(cos(radians(0))) # 1.0


print(dir(str))
for i in dir(list):
  print(i)