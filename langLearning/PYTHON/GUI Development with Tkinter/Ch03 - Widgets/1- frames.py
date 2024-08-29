from tkinter import *
from tkinter import ttk

root = Tk()

frame = ttk.Frame(root)
frame.pack()
frame.config(width=200 , height=100) # in px

#types of frame "relief": 1. Flat (no border)
#2. Raised 3. Sunken 4. Solid 5. Ridge 6. Groove
frame.config(relief= RIDGE)

ttk.Button(frame,text= "Click me").grid()
frame.config(padding= (30 , 15))

#LabelFrame: it has no relief except solid.
ttk.LabelFrame(root, height = 100, width = 200, text = "My Frame").pack()

root.mainloop()