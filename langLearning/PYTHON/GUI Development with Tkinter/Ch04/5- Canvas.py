from tkinter import *

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

root.mainloop()