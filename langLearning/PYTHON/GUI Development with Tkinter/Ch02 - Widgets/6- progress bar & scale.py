from tkinter import *
from tkinter import ttk

root = Tk()

progressbar = ttk.Progressbar(root, orient= HORIZONTAL, length= 200)
progressbar.pack()

progressbar.config(mode= 'indeterminate')
progressbar.start()
progressbar.stop()

progressbar.config(mode= 'determinate', maximum= 11.0, value= 4.2)
progressbar.config(value= 8.0)
progressbar.step() # one step: value = 9.0
progressbar.step(5) # 5 step: 9 + 5 = 14 -> 14 - 11 = 3 -> value = 3.0
value = DoubleVar()
progressbar.config(variable= value)


scale =ttk.Scale(root, orient= HORIZONTAL, length= 400, variable= value , from_= 0.0 , to = 11.0)
scale.pack()
scale.set(4.2)
# scale.get()


root.mainloop()