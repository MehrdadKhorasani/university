from tkinter import *
from tkinter import ttk

root = Tk()
button = ttk.Button(root, text = 'Click me')
button.pack()

button['text']
button['text'] = 'Press Me'
button.config(text = "Push me")
