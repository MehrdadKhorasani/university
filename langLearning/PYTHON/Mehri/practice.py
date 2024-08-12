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

"""
from datetime import datetime, timedelta

def calculate_birthdate(years, months, days):
    today = datetime.today()
    birthdate = today - timedelta(days=days) - timedelta(days=months*30) - timedelta(days=years*365)
    return birthdate

years = int(input("Please enter your age in years: "))
months = int(input("Please enter the number of additional months: "))
days = int(input("Please enter the number of additional days: "))

birthdate = calculate_birthdate(years, months, days)

print(f"Your birthdate is: {birthdate.strftime('%Y-%m-%d')}")
"""

"""
def get_student_info():
    students = []
    for i in range(10):
        print(f"Enter details for student {i+1}:")
        student_id = input("Student ID: ")
        first_name = input("First Name: ")
        last_name = input("Last Name: ")
        average = input("Average: ")
        student = [student_id, first_name, last_name, average]
        students.append(student)
    return students

def write_user_info(students):
    with open("students.txt", "w", encoding="utf-8") as myfile:
        for student in students:
            line = ",".join(student) + "\n"
            myfile.write(line)

def read_user_info():
    students = []
    with open("students.txt", "r", encoding="utf-8") as myfile:
        for line in myfile:
            student = line.strip().split(',')
            students.append(student)
    return students

def display_students(students):
    count = 1
    for student in students:
        student_id, first_name, last_name, average = student
        print(f"Student {count}:")
        print(f"  Student ID: {student_id}")
        print(f"  Name: {first_name} {last_name}")
        print(f"  Average: {average}\n")
        count += 1

students = get_student_info()

write_user_info(students)

loaded_students = read_user_info()

display_students(loaded_students)
"""

"""
#Volume of a rectangular cube
class rec_cube(object):
  
  def __init__(self,length, width, height):
    self.l = length
    self.w = width
    self.h = height

  def calc_rec_cube(self):
   volume = self.l * self.h * self.w
   print(f"the volume of your rectangle is {volume}")
  
print("type the length of rectangle:")
length = int(input())

print("type the width of rectangle:")
width = int(input())

print("type the height of rectangle:")
height = int(input())

rec1 = rec_cube(length, width, height)
rec1.calc_rec_cube()
"""


"""
# cylinder volume
from math import pi, pow

class cylinder_vol:
  def __init__(self, radius, height):
    self.r = radius
    self.h = height
  
  def calc_cylinder_vol(self):
    volume = pi * pow(self.r,2) * self.h
    print(f"the volume of your cylinder is {volume}")

print("type the radius of cylinder:")
radius = int(input())

print("type the height of cylinder:")
height = int(input())

cyl1 = cylinder_vol(radius, height)
cyl1.calc_cylinder_vol()
"""


"""
# Dictionary English to Persian
class Dictionary():
  def __init__(self):
    self.dictionary = []

  def add_word(self, english_word, persian_translation):
    self.dictionary.append({english_word, persian_translation})
    print(f"The word '{english_word}' added to your dictionary. It means '{persian_translation}' in Persian.")
  
  def translate(self, english_word):
    for word, translation in self.dictionary:
      if word == english_word: return translation
    return "Word not found"

  def print_dictionary(self):
    print(self.dictionary)

dict1 = Dictionary()
dict1.add_word("Apple", "سیب")
dict1.add_word("Tree", "درخت")
dict1.add_word("Human", "انسان")

print(dict1.translate("Apple"))
print(dict1.translate("Dress"))

dict1.print_dictionary()
"""