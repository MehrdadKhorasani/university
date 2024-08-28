from tkinter import *
import os

script_dir = os.path.dirname(os.path.abspath(__file__))
parent_dir = os.path.abspath(os.path.join(script_dir, os.pardir))
image_path = os.path.join(parent_dir, 'python_logo.gif')

root = Tk()

root.option_add('*tearOff', False)
menubar = Menu(root)
root.config(menu=menubar)

file = Menu(menubar)
edit = Menu(menubar)
help_ = Menu(menubar)

menubar.add_cascade(menu = file, label = "File")
menubar.add_cascade(menu = edit, label = "Edit")
menubar.add_cascade(menu = help_, label = "Help")

file.add_command(label = "New", command = lambda: print('New File'))
file.add_separator()
file.add_command(label = "Open...", command = lambda: print('Open File...'))
file.add_command(label = "Save", command = lambda: print('Save File'))
file.entryconfig('New', accelerator = 'Ctrl + N')
logo = PhotoImage(file= image_path).subsample(10,10)
file.entryconfig('Open...', image = logo, compound = 'left')
file.entryconfig('Open...', state= 'disabled')
file.delete('Save')

save = Menu(file)
file.add_cascade(menu = save, label = "Save")
save.add_command(label = "Save As", command = lambda: print('Saving As...'))
save.add_command(label = "Save All", command = lambda: print('Saving All...'))

choice = IntVar()
edit.add_radiobutton(label = "One", variable = choice, value = 1)
edit.add_radiobutton(label = "Two", variable = choice, value = 2)
edit.add_radiobutton(label = "Three", variable = choice, value = 3)

file.post(400,300)


root.mainloop()