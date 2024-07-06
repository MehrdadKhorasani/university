##### Strings Methods:

### isdigit:
n = "10"
print(n.isdigit()) #=> True
print("5".isdigit()) #=> True
print("10.5".isdigit()) #=> False
print("f2".isdigit()) #=> False
print("True".isdigit()) #=> False

### isalpha:
print("ali".isalpha()) #=> True
print("python3".isalpha()) #=> False
print("132".isalpha()) #=> False
print("3.5".isalpha()) #=> False
print("mehrdad khorasani".isalpha()) #=> False #because of space

### isalnum:
print("python3".isalnum()) #=> True
print("python".isalnum()) #=> True
print("3".isalnum()) #=> True
print("python 3".isalnum()) #=> False
print("1.3".isalnum()) #=> False

### isnumeric
print("123".isnumeric()) #=> True
print("nima".isnumeric()) #=> False
print("12.5".isnumeric()) #=> False

### isdecimal
print("10".isdecimal()) #=> True
print("10.5".isdecimal()) #=> False
print("test".isdecimal()) #=> False


#####
zero = "\u0030" # code zero
E = "\u0045" # code character 
p = "\u00b2" # code super script(2)

print(zero) #=> 0
print(E) #=> E
print(p) #=> ²

print(zero.isdigit()) #=> True
print(zero.isdecimal()) #=> True
print(zero.isnumeric()) #=> True

print(E.isdigit()) #=> False
print(E.isdecimal()) #=> False
print(E.isnumeric()) #=> False

print(p.isdigit()) #=> True
print(p.isdecimal()) #=> False
print(p.isnumeric()) #=> True


### isspace
print("   ".isspace()) #=> True
print("ali akbari".isspace()) #=> False
print("sara".isspace()) #=> False

