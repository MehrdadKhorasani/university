from tkinter import *


def closeWin(): exit()

win = Tk()

win.title("python")
# win.geometry("300x300+100+100")
win.configure(bg="pink", width="300", height="300")

menuBar = Menu(win)
menuFile = Menu(menuBar, tearoff=0)

menuFile.add_command(label="New")
menuFile.add_command(label="Open")
menuFile.add_separator()
menuFile.add_command(label="Close", command=closeWin)

menuBar.add_cascade(label= "File",menu= menuFile)

win.configure(menu=menuBar)
win.mainloop()