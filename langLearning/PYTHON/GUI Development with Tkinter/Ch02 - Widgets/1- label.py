from tkinter import *
from tkinter import ttk        
import os

    
root = Tk()

label = ttk.Label(root, text = "Hello, Tkinter!")
label.pack()
label.config(text = 'Howdy, Tkinter!')
label.config(text = 'Howdy, Tkinter! It\'s been a really long time since we last met.  Great to see you again!')
label.config(wraplength = 150)
label.config(justify = CENTER)
label.config(foreground = 'blue', background = 'yellow')
label.config(font = ('Courier', 18, 'bold'))
label.config(text = 'Howdy, Tkinter!')

####
script_dir = os.path.dirname(os.path.abspath(__file__))
parent_dir = os.path.abspath(os.path.join(script_dir, os.pardir))
image_path = os.path.join(parent_dir, 'python_logo.gif')
####

logo = PhotoImage(file=image_path) # change path to image as necessary
label.config(image = logo)
label.config(compound = 'text')
label.config(compound = 'center')
label.config(compound = 'left')

label.img = logo
label.config(image = label.img)

root.mainloop()
