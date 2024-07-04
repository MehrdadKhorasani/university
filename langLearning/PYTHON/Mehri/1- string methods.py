# length of a string:
str1="hello welcome to python"
#[start:end:step=1]
print(str1[0])
print(str1[4])
print(str1[-1])
lenght=len(str1)
print(lenght)
print(str1[lenght-1])
print(str1[0:3])
print(str1[0:7])
print(str1[10:])
print(str1[:])
print(str1[-6:])
print(str1[:15:2])
print(str1[::4])
print(str1[-1::-1])
print(str1[-10::-1])


##### Methods

### uppercase:
str1= str1.upper()
### lowercase:
str1= str1.lower()
### Capitalize:
str1= str1.capitalize()
### title
str1= str1.title()
# str1= str1.center()
# print(str1.center(80,"*"))
print(str1)


### Count method
print(str1.count("e")) # =>3
print(str1.count("o")) # =>4
print(str1.count("o", 10)) # =>3
print(str1.count("o", 10, 16)) # =>2

### Strip method:
str2 = "    hello   "
print(str2.strip()) #delete all the spaces
print(str2.lstrip()) #delete all the spaces from the left
print(str2.rstrip()) #delete all the spaces from thr right
str3 = "hello python3"
print(str3.lstrip("h")) #=> ello python3
print(str3.rstrip("n3")) #=> hello pytho
print("clear clic".strip("c")) #=> lear cli

### Split method
print(str1.split()) #unpack
#=> ['Hello', 'Welcome', 'To', 'Python']
print(str1.split("o"))
#=> ['Hell', ' Welc', 'me T', ' Pyth', 'n']

### Join method
list1 = str1.split()
print(" ".join(list1))
#=> Hello Welcome To Python
print("*".join("test"))
#=> t*e*s*t

### Just method
newStr = "hello welcome to python. python again"
print(newStr.ljust(30,"#"))
#=> hello welcome to python#######
print(newStr.rjust(30,"#"))
#=> #######hello welcome to python

### endswith method:
print(newStr.endswith("n")) #True
print(newStr.endswith("N")) #False

### startswith method:
print(newStr.startswith("h")) #True
print(newStr.startswith("H")) #False

### Find method
print(newStr.find("w")) #=> 6
print(newStr.find("to")) #=> 14
print(newStr.find("l")) #=> 2
print(newStr.find("python")) #=> 17
print(newStr.find("P")) #=> -1 #doesn't find in string
print(newStr.find("python",20)) #=> 25
print(newStr.find("python",16)) #=> 17

### rfind method
print(newStr.rfind('p')) #=> 25

### index method
print(newStr.index("o")) #=> 4
# print(newStr.index("H")) #=> error
#diff bet "index" & "find":
# if doesn't find the value: find returns -1 and index returns an error
print(newStr.rindex("o")) #=> 29


##### input function
name = input("please enter your first name:\n")
family = input("please enter your last name:\n")
print("Hello,", name.capitalize().strip(), family.strip(),end=".")
print("\nThanks.")
#=> Hello, Ali rohani.
#=> Thanks.
### convert the input
data = input("enter a value: ")
print(type(data))

# input always returns a string!
name = input("your name:")
family = input("your family:").capitalize().strip()
age = int(input("your age:"))

# String formating: f - format - %:
print(f"hi {name.title().strip()} {family}, your are {age} years old")

age_seconds = int(age) * 365 * 24 * 60 * 60
print(age)

print("hi {} {}, your age is {}".format(name.capitalize(),family,age))
print("hi {0} {2}, your age is {1}".format(name,age,family))

print("hi {name} {family}, your age is {age}".format(name = "mina",age = 12, family = "rezaie"))

print("hi %s %s, you are %d years old."%(name,family,age))
