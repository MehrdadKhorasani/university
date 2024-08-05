##### TKINTER Library
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