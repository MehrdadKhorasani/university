"""
numbers = []
for i in range(5):
  number = input("enter your number: ")
  if number.isdigit(): numbers.append(int(number))
  elif number.count(".") == 1 and number.replace(".","").isdigit():
    numbers.append(float(number))
  else: print("please enter the correct type of inputs (number)")
print(f"max number is: {max(numbers)}")
print(f"min number is: {min(numbers)}")
"""

"""
listOfNumbers = []
i = 0
while i < 20 :
 number = input("Enter your number: ") 
 if number.isnumeric() and int(number) % 5 == 0:
  i += 1
  continue
 elif number.isnumeric() and int(number)% 5 != 0 :
  number = int(number)
  listOfNumbers.append(number)
  i += 1
 else: print("please enter the correct type of inputs (number)")
else: print("*****")
print(listOfNumbers)
"""

"""
def triangle():
  while True:
    try:
      length = int(input("enter the length of triangle: "))
      width = int(input("enter the width of triangle: "))
      height = int(input("enter the height of triangle: "))
    except:
      print("please enter the correct type of inputs (number)")
    else:
      mass = length*width*height
      area = length*width
      print(f"the mass of triangle is {mass}. and the area of triangle is {area}")
      break
    finally:
      print("********")
triangle()
"""