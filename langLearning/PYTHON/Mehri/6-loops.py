##### LOOPS

### FOR
#1. range(start,end,step)
list1 = []
list2 = []
for i in range(5):
  print("prints 5 times")
  print(f"i = {i}")
  list1.append(i)
print(list1) #=> [0, 1, 2, 3, 4]
for i in range(5):
  name=input(f"enter a name {i+1}:")
  list2.append(name)
print(list2)
for item in range(1,10): 
  print(f"item={item}") #1 to 9
for item in range(1,50,5): 
  print(f"item={item}") #1 to 49 with 5 step: 1, 6, ..., 46

numbers = []
for n in range(5):
  number = input("enter a number: ")
  if(number.isdigit):
    number = int(number)
    if(number % 2 == 0):
      numbers.append(number)
print(numbers)

numbers = []
for n in range(5):
  number = input("enter a number: ")
  if(number.isdigit and int(number) % 2 == 0):
      numbers.append(int(number))
print(numbers)

for i in range(1,20):
  if (i == 10 or i == 12): 
    print("skip 10 and 12")
    continue # skip just this round
  if (i == 17):
    print('exit')
    break # skip the whole loop
  print(f"i={i}") #skip 10 , 12 , and all the numbers above 17

all_data = []
for i in range(1,5):
  data = input("enter a value:")
  if data == "100": continue
  if data.lower() == "quit" or data.lower() == "exit": break
  all_data.append(data)
else: # !!!!!!!!
# execute just when loop doesn't break
# else in for loop is just in python
  print(f"finished") 
print(all_data)



### WHILE