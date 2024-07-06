##### LISTS
list1 = ["one",120,True,"sara", 19.785 , "python", False]
print(list1) #=> ["one", 120, True, 'sara', 19.785, 'python', False]
print(type(list1)) #=> <class 'list'>

print(list1[0])
list1[0] = 1111
print(list1) #=> [1111, 120, True, 'sara', 19.785, 'python', False]

print(list1[:]) #=> [1111, 120, True, 'sara', 19.785, 'python', False]
print(list1[:3]) #=> [1111, 120, True]
print(list1[3:]) #=> ['sara', 19.785, 'python', False]
print(list1[-1]) #=> False
print(list1[-4:]) #=> ['sara', 19.785, 'python', False]
print(list1[-1:0:-1]) #=> [False, 'python', 19.785, 'sara', True, 120]
print(list1[::2]) #=> [1111, True, 19.785, False]

list1.append("mina")
print(list1) #=> [1111, 120, True, 'sara', 19.785, 'python', False, 'mina']
list2 = ["a", "b", "c"]
list1.append(list2)
print(list1) #=> [1111, 120, True, 'sara', 19.785, 'python', False, 'mina', ['a', 'b', 'c']]
list1.append(["ali","reza","sina"])
print(list1) #=> [1111, 120, True, 'sara', 19.785, 'python', False, 'mina', ['a', 'b', 'c'], ['ali', 'reza', 'sina']]

print(list1[-1]) #=> ['ali', 'reza', 'sina']
print(list1[-1][-1]) #=> sina

print(len(list1)) #=> 10

item = input("enter a data:")
list2.append(item)
print(list2)

newList = []
print(newList) #=> []

listChars = list("python3")
print(listChars) #=> ['p', 'y', 't', 'h', 'o', 'n', '3']

list3 = "hello welcome to python".split()
print(list3) #=> ['hello', 'welcome', 'to', 'python']

### range:
# range(start=0,end,step=1)
range(10) # 0 to 10 
range(1,10)
range(1,10,2)

listNumber = list(range(10))
listNumber1 = list(range(1,11))
listNumber2 = list(range(1,100,5))
print(listNumber) #=> [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
print(listNumber1) #=> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(listNumber2) #=> [1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 51, 56, 61, 66, 71, 76, 81, 86, 91, 96]