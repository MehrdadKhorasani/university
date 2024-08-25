from tkinter import *
from tkinter import ttk

root = Tk()

notebook = ttk.Notebook(root)
notebook.pack()
frame1 = ttk.Frame(notebook)
frame2 = ttk.Frame(notebook)
notebook.add(frame1, text = "One")
notebook.add(frame2, text = "Two")

ttk.Button(frame1, text = "Click me").pack()

frame3 = ttk.Frame(notebook)
notebook.insert(1, frame3, text= "Three")

notebook.forget(1)

notebook.add(frame3, text = "Three")

notebook.select()
notebook.index(notebook.select()) # 1
notebook.select(2) # ''

notebook.tab(1, state = 'disabled')

notebook.tab(1, state = 'hidden')
notebook.tab(1, state = 'normal')

notebook.tab(1, 'text') # 'Two'

notebook.tab(1)


root.mainloop()