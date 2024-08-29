from tkinter import *
from tkinter import ttk

root = Tk()

checkbutton =  ttk.Checkbutton(root , text = "SPAM?")
checkbutton.pack()

spam = StringVar()
spam.set("SPAM!")
spam.get() #=> SPAM!
checkbutton.config(variable= spam, onvalue= "SPAM PLEASE", offvalue= "BOO SPAM")


breakfast = StringVar()
ttk.Radiobutton(root, text = "SPAM", variable= breakfast, value= "SPAM").pack()
ttk.Radiobutton(root, text = "EGGS", variable= breakfast, value= "EGGS").pack()
ttk.Radiobutton(root, text = "Sausage", variable= breakfast, value= "Sausage").pack()
ttk.Radiobutton(root, text = "SPAM", variable= breakfast, value= "SPAM").pack()

breakfast.get()

checkbutton.config(textvariable= breakfast)

root.mainloop()