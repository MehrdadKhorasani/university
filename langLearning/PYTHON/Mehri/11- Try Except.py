##### Python Try Except

# form:
try:
  pass
except:
  pass

#example:
try:
  print(number)
except:
  print("Error: there is a problem with your code!")
# Error: there is a problem with your code!

#example 2:
try:
  print(number)
except NameError as e: #e for event
  print(f"Error: {e}!")
# Error: name 'number' is not defined!

#example 3:
try: n = int("2.5")
except ValueError as e: print(f"Error: {e}!") 
  
# Error: invalid literal for int() with base 10: '2.5'!

#example 4:
try: 
  list1 = [10,5,6]
  print(list1[8])
except IndexError as e: print(f"Error: {e}!")
#Error: list index out of range!

#example 5:
def convertToInteger(number):
  try: return int(number)
  except: return 0
print(convertToInteger("5")) #5
print(convertToInteger("10")) #10
print(convertToInteger("2.5")) #0

#example 6:
def getNumber():
  while True:
    try:
      number = int(input("Enter a number: "))
      return number
    except:
      continue
getNumber()

#example 7:
def power():
  while True:
    try:
      number = int(input("enter your number: "))
    except:
      continue
    else: 
      # if try was ok, then this run
      print(number**2)
    finally:
      # runs anyways
      print("the end")
      return
power()


# example 8:
def calculator():
  operator = ["+", "-", "*", "/"]
  while True:
    try:
      number1 = float(input("enter your first number: "))
      number2 = float(input("enter your second number: "))
      op = input("select an operator (+,-,*,/): ")
    except ValueError as e:
      print(f"please enter a valid input. {e}")
      continue
    else:
      if op in operator: 
        if op == "+": print(f"sum is {number1 + number2}")
        elif op == "-": print(f"subtract is {number1 - number2}")
        elif op == "*": print(f"multiply is {number1 * number2}")
        elif op == "/":
          try: print(f"division is {number1 / number2}")
          except ZeroDivisionError as e: print("could not division by zero!")
        break
      else: 
        print("please enter a valid operator")
        continue
    finally: 
      print("**********")
calculator()