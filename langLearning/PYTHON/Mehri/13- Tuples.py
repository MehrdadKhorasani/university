##### TUPLEs
tuple1 = ("one", 10, True, 2.5, False, "ali")
#tuples are unchangable: read only data structure
print(type(tuple1)) # <class 'tuple'>
print(tuple1[2])
print(tuple1[-1])
print(tuple1[:3]) # ('one', 10, True)
print(tuple1[-4:4]) # (True, 2.5)
print(tuple1[::2]) # ('one', True, False)

t2 = ("one", 2 , True)
a,b,c = t2
print(b) # 2

t3 = tuple(range(10,50,5))
print(t3) # (10, 15, 20, 25, 30, 35, 40, 45)

char = tuple("hello world")
print(char) # ('h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd')

numbers = tuple((x*10) for x in range(10))
numbers2 = tuple((x*10) for x in range(1,11))
print(numbers) # (0, 10, 20, 30, 40, 50, 60, 70, 80, 90)
print(numbers2) # (10, 20, 30, 40, 50, 60, 70, 80, 90, 100)

t4 = (50)
print(t4) # 50
print(type(t4)) # <class 'int'>

t4 = (50,)
print(t4) # (50,)
print(type(t4)) # <class 'tuple'>

t5 = 12, True, "hello", 5 + 2, 10 < 21
print(t5) # (12, True, 'hello', 7, True)
print(type(t5)) # <class 'tuple'>

t6 = ()
print(t6) # ()
print(type(t6)) # <class 'tuple'>

###
tuple1 = ("one", 10, True, 2.5, False, "ali")
# there are only two methods for tuples:
print(tuple1.count("one")) #1
print(tuple1.index(2.5)) #3

print(len(tuple1)) # 6
# len is not a tuple's method.

tuple2 = tuple(range(1,50,5))
tuple3 = tuple1 + tuple2 + (9,12,15)
print(tuple3)
# ('one', 10, True, 2.5, False, 'ali', 1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 9, 12, 15)

### DELETE A TUPLE:
# del tuple3
# print(tuple3) # NameError: name 'tuple3 is not defined

tuple4 = ("Nima", "Sima", (23, True,"False"), 8, [10, 20])
print(tuple4[2]) # (23, True, 'False')
print(tuple4[2][1]) # True
print(tuple4[-1]) # [10, 20]
print(tuple4[-1][1]) # 20


### Convert tuple to list
newList = list(tuple4)
print(newList) # ['Nima', 'Sima', (23, True, 'False'), 8, [10, 20]]
print(type(newList)) # <class 'list'>
newList.append("test add item")
newList.insert(2, "GoodBye")
print(newList) # ['Nima', 'Sima', 'GoodBye', (23, True, 'False'), 8, [10, 20], 'test add item']

### Convert list to tuple
newTuple = tuple(newList)
# again, it is unchangable


###
tOne = ("one", 10, True, 2.5, False, "ali")
tTwo = ("Nima", "Sima", 8, [10, 20])

if "ali" in tOne:
  print("found") # found
else:
  print("not found")

if "Sima" not in tTwo:
  print("yes") 
else:
  print("false") # false