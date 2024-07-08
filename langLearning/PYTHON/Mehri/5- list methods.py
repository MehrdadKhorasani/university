list1 = [12,5,15,6,8]
listName = ["Sara", "mina", "tina", "reza"]

###### list methods:

#### 5 ways to delete item/items/all from list (itself):

### 1. pop method
item = listName.pop()
print(listName) #=> ['Sara', 'mina', 'tina']
print(item) #=> reza

print(list1.pop(1)) #=> 5
print(list1) #=> [12, 15, 6, 8]


### 2. remove method: don't return anything
print(listName.remove("mina")) #=> None
print(listName) #=> ['Sara', 'tina']

# Error: if element doesn't exist:
# listName.remove("Ali") #=> error
# list1.pop(9) #=> error

### 3. del metod:
del listName[0]
print(listName) #=> ['tina']

### 4. del method: delete the entire list
#del listName
#print(listName) #=> ['tina'] #=> Error: name 'listName' is not defined

### 5. clear method: make empty a list:
list1.clear()
print(list1) #=> []

### insert method:
list1.insert(0,8)
list1.insert(1,20)
print(list1) #=> [8, 20]
list1.insert(0,3)
print(list1) #=> [3, 8, 20]
list1.insert(30,9)
print(list1) #=> [3, 8, 20, 9]
print(list1.index(9)) #=> 3

### sort
list1 = [12,5,15,6,8]
listName = ["Sara", "mina", "tina", "reza"]
list1.sort()
print(list1) #=> [5, 6, 8, 12, 15]
### reverse
list1.reverse()
print(list1) #=> [15, 12, 8, 6, 5]
# for reverse and sort methods, all the items must have same type.if there was more than a type of items, an error occurred

### extend method
list1.extend([listName])
print(list1)
#=> [15, 12, 8, 6, 5, ['Sara', 'mina', 'tina', 'reza']]

### join method
str1 = ",".join(listName)
print(str1) #=>Sara,mina,tina,reza

### copying list:
list1 = [12,5,15,6,8]
list2 = list1
print(list1) #=> [12, 5, 15, 6, 8]
print(list2) #=> [12, 5, 15, 6, 8]
list2.pop()
print(list1) #=> [12, 5, 15, 6]
print(list2) #=> [12, 5, 15, 6]
print(id(list1)) #=> 2106548092096
print(id(list2)) #=> 2106548092096
# so in this way, it mutate the original array. because two lists points to a same memory address
#correct way:

### copy method:
newlist = list1.copy()
newlist.pop()
print(id(list1)) #=> 2376984362240
print(id(newlist)) #=> 2376984312960
print(list1) #=> [12, 5, 15, 6]
print(newlist) #=> [12, 5, 15]

### sum method
print(sum(list1)) #=> 38

##### exercise
scores = []
fullName = input("Enter first name and family:\n").strip()
math = input("enter math score:")
physics = input("enter physics score:")
art = input("enter art score:")
if(physics.isdigit() and math.isdigit() and art.isdigit()):
  scores.append(int(math))
  scores.append(int(physics))
  scores.append(int(art))
  average = sum(scores) / len(scores)
  print(f"{fullName} your average is: {average:.2f}")
  if 0 < average < 10:
    print("grade c")
  elif 10 < average < 15:
    print("grade b")
  elif 15 < average <= 20:
    print("grade A")
  else: print("false as fuck bro!")
else: print("please enter valid input for scores")
print(scores)