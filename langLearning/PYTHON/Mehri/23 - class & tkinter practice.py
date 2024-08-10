"""
import time
class person:
  list_person = []
  def __init__(self, name,family,age):
    self.firstName = name
    self.lastName = family
    self.birthdate = ""
    if isinstance(age,int): self.age = age
    else: self.age = 0
    person.calcBirthDate(self)
    person.list_person.append([self.firstName,self.lastName,self.age,self.birthdate])

  
  def calcBirthDate(self):
    time_second = time.time()
    age_second = self.age * 365 * 24 * 60 * 60
    birtdate = time_second - age_second
    self.birthdate = time.ctime(birtdate)
    return self.birthdate
  
  def displayPerson(slef):
    if len(person.list_person) > 0:
      for i in person.list_person:
        print(f"{i[0]} {i[1]}")

  def __str__(self):
    return f"my name is {self.firstName} {self.lastName} , my birthday is on {self.birthdate}"
  
  def __del__(self):
    print("person was deleted successfully.")

p1 = person("mahdi", "salimi", 27)
p2 = person("nima", "nazari", 21)
print(p1.list_person)
#=> [['mahdi', 'salimi', 27, 'Sun Aug 17 18:55:03 1997'], ['nima', 'nazari', 21, 'Sat Aug 16 18:55:03 2003']]
print(p2)
#=> my name is nima nazari , my birthday is on Sat Aug 16 18:58:03 2003

p2.displayPerson()
#=> mahdi salimi
#=> nima nazari

del p2
"""

"""
from tkinter import *
import time

def clock():
  time1 = time.strftime("%H:%M:%S")
  lbl_clock.config(text = time1)
  lbl_clock.after(1000,clock)

win = Tk()
win.title("Class Python")
win.geometry("150x100+100+150")
win.resizable(0,0)
win.configure(background="skyblue")
lbl_clock = Label(text="First Name:",font=("Arial 12"), bg = "black",fg="white",bd="1", width="12", height="1")
lbl_clock.grid(row= 0, column=0, pady="10",padx="5")

clock()
win.mainloop()
"""