from tkinter import *
from tkinter import ttk

def mouse_press(event):
  global prev
  prev = event
  print('type: {}'.format(event.type))
  print('widget: {}'.format(event.widget))
  print('num: {}'.format(event.num))
  print('x: {}'.format(event.x))
  print('y: {}'.format(event.y))
  print('x_root: {}'.format(event.x_root))
  print('y_root: {}'.format(event.y_root))

def draw(event):
  global prev
  canvas.create_line(prev.x, prev.y, event.x, event.y, width = 5)
  prev = event

root = Tk()

canvas = Canvas(root, width = 640, height= 480, background = 'white')
canvas.pack()

canvas.bind("<ButtonPress>", mouse_press)
canvas.bind("<B1-Motion>", draw)

root.mainloop()