from tkinter import *
import os

script_dir = os.path.dirname(os.path.abspath(__file__))
parent_dir = os.path.abspath(os.path.join(script_dir, os.pardir))
image_path = os.path.join(parent_dir, 'python_logo.gif')

root = Tk()

canvas = Canvas(root)
canvas.pack()

canvas.config(width=640, height = 480)
line = canvas.create_line(160, 360, 480,120, fill ='blue', width = 5)

canvas.itemconfig(line, fill = 'green')
canvas.coords(line) #[160.0, 360.0, 480.0, 120.0]
canvas.coords(line, 0, 0, 320, 240, 640, 0)

canvas.itemconfigure(line, smooth = True)
canvas.itemconfigure(line, splinesteps = 5)
canvas.itemconfigure(line, splinesteps = 1)
canvas.delete(line)

rect = canvas.create_rectangle(160,120,480,360)
canvas.itemconfig(rect,fill = 'yellow')

oval = canvas.create_oval(160,120,480,360)

arc = canvas.create_arc(160,1,480,240)
canvas.itemconfigure(arc, start = 0, extent = 180, fill = 'green')

poly = canvas.create_polygon(160,360,320,480,480,360,fill = 'blue')

text = canvas.create_text(320,240, text= 'Python', font = ('Courier', 32, 'bold'))

logo = PhotoImage(file= image_path)
image = canvas.create_image(320,240, image = logo)

canvas.lift(text)
canvas.lower(image)
canvas.lower(image, text)

button = Button(canvas, text = 'Click Me')
canvas.create_window(320,60,window = button)

canvas.itemconfigure(rect, tag = ('shape'))
canvas.itemconfigure(oval, tag = ('shape', 'round'))
canvas.itemconfigure('shape', fill = 'grey')
canvas.gettags(oval) #('shape', 'round)

root.mainloop()