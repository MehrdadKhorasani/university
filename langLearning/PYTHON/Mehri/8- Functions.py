def showMessage():
    """
    docstring:
    this function for show message

    """
    data=input("Please type a message for ptint:")
    print(data.upper())

# call function

# showMessage()
print(showMessage.__name__)
print(showMessage.__doc__)

len=len("hi")
print("hi".__len__())
print(len)
# print(len("hi"))
# help("symbols")
# help("keywords")

def hiPerson(name,family):
    '''
    this function get two parameter then  show message

    '''
    print(f"Hello {name.title()} {family.title()}. welcome to python learning")

def hiUser(name="",family="ahmadi"):
    '''
    this function get two parameter then  show message

    '''
    print(f"Hello {name.title()} {family.title()}. welcome to python learning")


# hiPerson("sara","zamani")
#
# hiUser("reza","rezaee")
# hiUser("ali")
# hiUser()
# firstName=input("type your name:")
# lastName=input("type your family:")
# hiPerson(firstName,lastName)

def sumNumbers(n,m,x,z):
    sum=int(n)+int(m)+int(x)+int(z)
    return sum

# print(sumNumbers(2,5,10,7))
# s=sumNumbers(10,30,25,70)
# print("sum=",s)

def sum_ave_Numbers(n,m,x,z):
    sum=int(n)+int(m)+int(x)+int(z)
    average=sum/4
    return (sum,average)

# print(sum_ave_Numbers(10,2,5,12))
# s,ave=sum_ave_Numbers(10,120,5.5,40.75)
# print(f"sum is:{s} , average is :{ave:.2f}")

def factorial(number):
    if number<=1:
        return number
    return number*factorial(number-1)  # 3*2*1

# print(factorial(3))  # 3*2*1
# print(factorial(4))  # 4*3*2*1
# print(factorial(1))  # 4*3*2*1

def isFloat(number):
    if number.count(".")==1 and number.replace(".","").isdigit():
        return True
    else: return False

# print(isFloat("5"))
# print(isFloat("2.5"))
def circleArea(radius,pi=3.14):
    if isFloat(radius) :
        return pi * float(radius) * float(radius)

    elif radius.isdigit():
        return pi * int(radius) * int(radius)

    else: return 0

"""
r=input("enter circle radius:")
result=circleArea(r)
print(f"{result:.2f}")
"""

'''
def mergeList_odd_even(list1,list2):
    result=[]
    for item in list1:
        if item%2==1:
            result.append(item)
    for item in list2:
        if item%2==0 or item%5==0 :
            result.append(item)
    return result

list1=[14,3,6,10,5,7]
list2=[25,1,14,8,5,10,9,30,7,13]
print(mergeList_odd_even(list1,list2))

'''
# scope local , global
number1=100

def sum(n,m):
    global  number1
    print(number1)
    number1+=n+m  # 3**2
    print(number1)

sum(5,5)

print(number1)
sum(10,20)
print(number1)

print(pow(2,3))
print(pow(5,2))
list1=[14,3,6,10,5,7]
list2=[25,1,14,8,5,10,9,30,7,13]
print(min(list2))
print(max(list2))
print(sum(list1))

