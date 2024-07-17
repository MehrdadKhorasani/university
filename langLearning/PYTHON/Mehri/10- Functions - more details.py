# other ways to write functions

##### function with changeable numbers of arguments
# form:
def sumNumbers(*args):
  print(args)
sumNumbers() # ()
sumNumbers(10) # (10,)
sumNumbers(10,2,5) # (10, 2, 5)
sumNumbers(1000,21,15,70,12) # (1000, 21, 15, 70, 12)

#example:
def scoresAverage(name,*marks):
  sumNumbers = 0
  for mark in marks:
    sumNumbers+=mark 
  length = len(marks)
  if length > 0:
    avg = sumNumbers / length
    print(f"hi {name.upper()}, your average is {avg:.2f} ")      
  else: print(f"hi {name.upper()}, your average is 0 ")

name = input("Enter your name:").strip()
math = input("Enter your math score:")
physics = input("Enter your physics score:")
computer = input("Enter your computer score:")

scoresAverage(name, int(math), int(physics), int(computer))
scoresAverage("reza", 20,18.5) # hi REZA, your average is 19.25

##### list as an argument:
def sum_lists(listA, listB):
  sum_numbers = []
  if len(listA) == len(listB) and len(listA) > 0 :
    for i in range(len(listA)):
      sum_numbers.append(listA[i] + listB[i])
  return sum_numbers
a = [10,15,7,3]
b = [100,5,2,30]
print(f"sum numbers:{sum_lists(a,b)}")
# sum numbers:[110, 20, 9, 33]


##### nameless functions (lambda) & map function
# example 1:
squar= lambda x:x**2
print(squar(10)) # 100
print(squar(3)) # 9

# example 2:
add = lambda x,y:x+y
print(add(5,7)) # 12

# example 3:
list1 = [2,5,7,9,8,3]
result = map(lambda x: x*x,list1)
print(list(result)) # [4, 25, 49, 81, 64, 9]

# example 4:
name = ["ali", "reza", "mina"]
nameResult = list(map(lambda x: x.upper(),name))
print(nameResult) # ['ALI', 'REZA', 'MINA']

# example 5:
name = ["2", "5", "13"]
intResult = list(map(int,name))
print(intResult) # [2, 5, 13]

#example 6:
# from math import *
from math import sqrt
numbers = [103,25,64,81]
result = list(map(sqrt,numbers))
print(result) # [10.14889156509222, 5.0, 8.0, 9.0]
