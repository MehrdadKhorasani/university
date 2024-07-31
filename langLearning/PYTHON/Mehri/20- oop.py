# OOP: Object Oriented Programming


class test: 
  """
  define new class for test
  """
  message = "welcome to oop"
t1 = test()
print(t1.__doc__) #   define new class for test
print(t1.message) # welcome to oop
t1.message = "this is a class object"
print(t1.message) # this is a class object

###
class person(object):
  name = ""
  family = ""

  # methods:
  def set_name(self,firstName):
    person.name = firstName
  def get_name(self):
    print(f"hello {self.name}")
  def set_family(self,lastName):
    person.family = lastName
  def get_family(self):
    print(f"hello {person.family}")
  def showPerson(self):
    print(f"welcome {person.name} {person.family}")

  def __str__(self):
    return f"welcome {person.name} {person.family}"

p1 = person()
p1.set_name("MINA")
print(p1.name) # MINA
p1.get_name() # hello MINA
p1.set_family("Mehri")
p1.get_family()
print(p1) # welcome MINA Mehri

print(p1.__dict__)

p2 = person()
p2.set_name("Javad")
p2.set_family("Samimi")
p2.showPerson()
print(p2)


class students:
  student_count = 0
  student_list = []
  def set_student(self,name,family):
    students.student_count += 1
    students.student_list.append([name,family])
  def show_count(self):
    print(f"students count: {students.student_count}")
  def __str__(self): return f"students: {students.student_list}"

student1 = students()
student1.set_student("Mehrdad", "Khorasani")
student1.show_count() # 1
print(student1) # students: [['Mehrdad', 'Khorasani']]

student2 = students()
student2.set_student("Ali", "Rezai")
student2.show_count() # 2
print(student1) # students: [['Mehrdad', 'Khorasani'], ['Ali', 'Rezai']]