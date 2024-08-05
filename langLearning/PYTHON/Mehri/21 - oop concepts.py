##### OOP more practices:

"""
##### ENCAPSULATION
### PUBLIC:
class rectangle:
  def set_width(self,width):
    self.width = width
  def set_height(self,height):
    self.height = height
  
  def rect_area(self):
    self.area = self.width * self.height
    print(f"rectangle area is: {self.area}")

# access directly to inside-variables of class:
rec1 = rectangle()
rec1.width = 10
rec1.height = 2
rec1.rect_area() # rectangle area is: 20

# use the setter methods to set value:
rec2=rectangle()
rec2.set_height(5)
rec2.set_width(3)
rec2.rect_area() # rectangle area is: 15

# public, private, protected: in python everything is public



### Protected:
class rectangle2:
  def set_width(self,width):
    self._width = width
  def set_height(self,height):
    self._height = height
  
  def rect_area(self):
    self._area = self._width * self._height
    print(f"rectangle area is: {self._area}")

rec3 = rectangle2()
rec3._width = 10
rec3._height = 2
rec3.rect_area() # rectangle area is: 20



### Private:
## accessable just in class
class rectangle3:
  def set_width(self,width):
    self.__width = width
  def __set_height(self,height):
    self.__height = height
  
  def rect_area(self):
    self.__area = self.__width * self.__height
    print(f"rectangle area is: {self.__area}")

rec4 = rectangle3()
rec4.__width = 10
rec4.__height = 2
# OR:
rec4.__set_height(5)
rec4.rect_area() # ERROR
"""

### CONSTRUCTOR (initialize function):
# class person:
# OR:
class person(object):
  def __init__(self, name, family, phone = None):
    self.first_name = name
    self.last_name = family
    self.phone_number = phone

  def show_info(self):
    print(f"Hello {self.first_name} {self.last_name}. Your phone Number is {self.phone_number}.")

p1 = person("Sarah", "Walter", "012336484")
p1.show_info()
# Hello Sarah Walter. Your phone Number is 012336484.
print(p1.first_name) # Sarah

p2 = person("Ali", "Zamani")
p2.show_info()
# Hello Ali Zamani. Your phone Number is None.


##### Inheritance:
class student(person):
  def __init__(self, name, family, phone, average):
    person.__init__(self, name, family, phone)
    self.average = average
  def display_average(self):
    print(f"{self.first_name} {self.last_name} with average of {self.average}")

  def __str__(self):
    return f"the student is {self.first_name} {self.last_name}"
  """
  ### Polymorphism:
  def show_info(self):
    print(f"Hi {self.first_name} {self.last_name}. Your phone Number is {self.phone_number}.")
  """

st1 = student("Mehrzad", "Asgari", 9119865665, 17)
st1.display_average() # Mehrzad Asgari with average of 17
# access to parent's methods:
st1.show_info() 
# Hello Mehrzad Asgari. Your phone Number is 9119865665.
### this below one is printed if the polymorpism was on:
# Hi Mehrzad Asgari. Your phone Number is 9119865665.
print(st1) # the student is Mehrzad Asgari


class teacher(person):
  def __init__(self, name, family, phone, id, address, education):
    person.__init__(self,name, family, phone)
    # super().__init__(self,name, family, phone)
    self.id = id
    self.address = address
    self.education = education
  def show_info(self):
    # super().show_info()
    print(self.id,end=" ")
    person.show_info(self)
    print(self.address, self.education,sep= "   ")

tea1 = teacher("Zahra", "mehri", 91188554, "0011", "mashhad", "PHD")
tea1.show_info()
# 0011 Hello Zahra mehri. Your phone Number is 91188554.
# mashhad   PHD