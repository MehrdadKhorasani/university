from tkinter import *
from tkinter import ttk

def callback():
  print("Clicked!")

root = Tk()

button = ttk.Button(root, text = "Click me")
button.pack()
button.config(command= callback)

# button.invoke()

button.state(['disabled'])
button.instate(['disabled']) #=> True returns a bool value of state

button.state(["!disabled"])

logo = PhotoImage(file = 'python_logo.gif')

button.config(image = logo, compound= LEFT)
small_logo = logo.subsample(5, 5)
button.config(image = small_logo)


root.mainloop()