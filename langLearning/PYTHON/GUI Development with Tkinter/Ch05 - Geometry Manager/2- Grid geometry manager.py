from tkinter import *
from tkinter import ttk

# GRID is very good for organizing widgets in two dimensions

root = Tk()

root.rowconfigure(0, weight = 1)
root.rowconfigure(1, weight = 3)

root.columnconfigure(2, weight= 1)

"""
ttk.Label(root, text = 'Yellow', background = "yellow").grid(row = 1, column = 1)
ttk.Label(root, text = 'Blue', background = "skyblue").grid(row = 1, column = 0)
ttk.Label(root, text = 'Red', background = "orangered").grid(row = 0, column = 0)
ttk.Label(root, text = 'Green', background = "springgreen").grid(row = 0, column = 1)
"""

ttk.Label(root, text = 'Yellow', background = "yellow").grid(row = 0, column = 2, rowspan= 2, sticky = 'nsew')
ttk.Label(root, text = 'Blue', background = "skyblue").grid(row = 1, column = 0, columnspan= 2, sticky = 'nsew')
ttk.Label(root, text = 'Red', background = "orangered").grid(row = 0, column = 0, sticky = 'nsew', padx = 10, pady = 10)
ttk.Label(root, text = 'Green', background = "springgreen").grid(row = 0, column = 1, sticky = 'nsew', ipadx = 25, ipady = 25)


root.mainloop()


"""
THESE ARE ALSO AVAILABLE IN GRID MANAGER:
grid_slaves()
grid_configures()
grid_info()
grid_forget()
"""