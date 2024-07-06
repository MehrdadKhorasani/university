##### IF ELIF ELSE
number = 100
if number == 10:
  print("*" * number)
  print(number**2)
else: 
  print("Number = ", number)

num = input("Enter a number:")
if num.isdigit():
  num = int(num)
  if num % 2 == 0:
    print(f"{num} is an even number")
  else:
    print(f"{num} is an odd number")
else:
  print("invalid input type!")

firstNumber = input("enter first number:")
secondNumber = input("enter second number:")
operand = input("enter a operand (+,-,/,*): ")
#example1:
if firstNumber.isdigit() & secondNumber.isdigit():
  print(f"sum number is: {int(firstNumber) + int(secondNumber)}")
else: print("invalid input type!")
#example2:
if firstNumber.isdigit() & secondNumber.isdigit():
  if operand == "+":
    print(f"sum number is: {int(firstNumber) + int(secondNumber)}")
  elif operand == "-":
    print(f"subtract number is: {int(firstNumber) - int(secondNumber)}")
  elif operand == "*":
    print(f"multiple number is: {int(firstNumber) * int(secondNumber)}")
  elif operand == "/":
    if int(secondNumber) > 0:
      print(f"division number is: {int(firstNumber) / int(secondNumber)}")
    else: print("division by zero is invalid")
  else:
    print("wrong operand")

### Short ways to write if statement:
n = 10
if n > 5: print(f'{n} is greater that 5')
if n != 10: print(f'{n} is not equal to 10')
print("even") if n % 2 == 0 else print("odd")

### convert to float:
m = "12.5"
if m.count(".") == 1:
  if m.replace(".","").isdigit():
    print(float(m))

score = input("enter score:")
if score.isdigit():
  print(f"score is {int(score)}")
elif score.count('.')== 1 and score.replace(".","").isdigit():
  print(f"score is {float(score)}")
else: print("invalid score")

##### Escape characters (\n , \t , \\ , \r , \' , \"):
print("hello\tmina") #tab
print("hello\nmina") #new line
print("hello\\mina") #back slash
print("hello\rmina") #سرخط
print('he\'s mine') #single quote
print("hello\"mina\"") #double quote