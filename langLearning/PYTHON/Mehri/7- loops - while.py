"""
number=input("Enter a number:")
if number.isdigit():
    number=int(number)
    # if number%2==0:
    #     print(f"{number} is even")
    # else:        print(f"{number} is odd")

# prime : اعداد اول بجز یک و خودش  بر عدد دیگری بخش پذیر نیستند
#7=(1,2,3,4,5,6,7)

    for i in range(2,number):   #5= 2,3,4
        if number%i==0:  # 5%2==1,5%3==2 , 5%4==1
            print(f"{number} is not prime")
            break
    else:
        print(f"{number} is  prime")
"""
"""
for i in range(1,10):  # row
    for j in range(1,i):  # column
        print("*"*(i-j) ,end="")
    print()

for i in range(1,11):
    for j in range(1,11):
        print(f"{i}*{j}={i*j}",sep=" , ",end=" ")
              
    print()
"""

"""
for c in "hello world":
    # print(c*5)
    print(c.upper())

print("*"*10)

str1="welcome to python"
for i, c in enumerate(str1,start=1):
    # print(c*5)
    print(f"{i} ) {c.upper()}")

print("*"*10)

list1=["ali","sara","mina","sina"]
for i, name in enumerate(list1,start=1):
    # print(c*5)
    print(f"{i} ) {name.upper()}")
    
"""

'''
listNumber=[3 for n in  range(6)]
print(listNumber)

listNumber=[3*n for n in  range(6)]
print(listNumber)
matrix=[
    [1,2,3,4],
    [5,6,7,8],
    [10,20,30,40]
]
print("*"*5)
for row in matrix:
    # print(row[0],row[3])
    for column in row:
        # print(column,sep=" - ",end=" ")
        print(f"{row[0]* column} ")
    print()

list2=[[2*i,3*3,i] for i in range(1,12,2)]
print(list2)

list1=["ali","sara","mina","sina","ali","mina"]
newlist=[n.upper() for n in list1 if n=="ali" ]
print(newlist)

numbers=list(range(0,20))
print(numbers)
newlist=[n for n in numbers if n%2==1]
print(newlist)
print(list1[::-1])
'''

'''
n=1
while(n<=10): # True
    print("n=",n)
    n+=1  # n=n+1
'''

"""
m=1
while(True):
    print("m=",m)
    m-=1
    if m==-5:
        break

while(True):
    data=input("enter a value:")
    print(data)
    if data.upper()=="EXIT" or data.upper()=="quit":
        break
"""


while(True):
    data=input("enter a Number( for exit type(e or q):")
    if data.isdigit() and int(data)%2==0:
        print(f"{data} is digit and even")

    elif data.upper()=="E" or data.upper()=="Q":
        break

    else:print("try again!")
else:
    print("end get data")


n=0
while(n<15):
    n += 1
    if n==10:
        continue
    print(n)
else:
    print("end loop")
    