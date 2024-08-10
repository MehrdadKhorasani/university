"""
##### TKINTER Library
# EXAMPLE 1
# import tkinter as tk
import tkinter

def closeWin():
  exit()

win = tkinter.Tk()
win.geometry("300x250+200+50") # w*h+x+y
win.configure(background="pink")
win.title("pink python")
win.resizable()
#win.resizable(1,0) # w h # 1=able 0=disable
# enable by default
#win.resizable(True,False) #True & False == 1 , 0

lbl_name = tkinter.Label(win, bg="lightblue", text= "Name", width=8, height=2, font=("cascadia code",14)) # Master(parent element), others are not mandatory
lbl_name.grid(row = 0, column = 0)

ent_name = tkinter.Entry(win,width=15, font=("arial", 14),bg="gold").grid(row=0,column=1)

btn1 = tkinter.Button(win,width=6, height=2, bg="lightgreen",fg="darkblue",text="click me")
btn1.grid(row=1,column=1)


btn2 = tkinter.Button(win,width=6, height=2, bg="lightgreen",fg="darkblue",text="exit", command=closeWin)
btn2.grid(row=10,column=1)



win.mainloop()
"""

# EXAMPLE 2
from tkinter import *
from tkinter import messagebox
# if you use bind method, must add event parameter (event is an exampe name. you can use "e")
def closeWin(event): 
  q = messagebox.askyesno("Are you sure?")
  if(q == True): exit()
def show(event):
  name = ent_name.get()
  lbl_res.configure(text=name.title())
  ent_name.delete(0,END)
  ent_name.focus
def changeText(event):
  lbl_res.configure(fg="red")
  lbl_res.configure(text=ent_name.get().upper())

win = Tk()
win.title("Class Python")
win.geometry("300x300+100+150")
win.resizable(0,0)
win.configure(background="skyblue")
Label(text="First Name:",font=("Arial 12"), bg = "#c1c1c1",fg="blue",bd="1", width="12", height="1").grid(row= 0, column=0, pady="10",padx="5")
ent_name = Entry(win,font=("Arial 12"), bg = "#c1c1c1",fg="blue",bd="1", width="12")
ent_name.grid(row = 0, column = 1, pady = "10",padx = "5", sticky = N, ipadx = 3)
lbl_res = Label(text="Result:",font=("Arial 12"), bg = "#ccc",fg="blue",bd="1", width="12", height="1")
lbl_res.grid(row= 1, column=0, pady="10",padx="5")

"""
btn_show = Button(win,width=6, height=2, bg="lightgreen",fg="darkblue",text="show",command=show)
btn_show.grid(row=3,column=1)

btn_exit = Button(win,width=6, height=2, bg="lightgreen",fg="darkblue",text="exit", command=closeWin)
btn_exit.grid(row=3,column=2)
"""

btn_show = Button(win,width=6, height=2, bg="lightgreen",fg="darkblue",text="show")
btn_show.grid(row=3,column=1)

btn_exit = Button(win,width=6, height=2, bg="lightgreen",fg="darkblue",text="exit")
btn_exit.grid(row=3,column=2)

btn_exit.bind("<Button>", closeWin)
btn_show.bind("<Button>", show)
ent_name.bind("<Key>", changeText)


win.mainloop()