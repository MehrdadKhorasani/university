# three types of geometry managers in Tk:
# 1. Pack (simplest)  # 2. Grid # 3. Place

from tkinter import *
from tkinter import ttk

root = Tk()
"""
ttk.Label(root, text = "Hello, Tkinter!",
           background = 'yellow').pack(fill = BOTH, expand = True) #FILL: #1.X #2.Y #3.BOTH
ttk.Label(root, text = "Hello, Tkinter!", background = 'skyblue').pack(fill = BOTH)
ttk.Label(root, text = "Hello, Tkinter!", background = 'orangered').pack(fill = BOTH, expand = True)
"""

label = ttk.Label(root, text = "Hello, Tkinter!", background = 'yellow')
label.pack(side = LEFT, anchor = 'nw') #nw: northwest
ttk.Label(root, text = "Hello, Tkinter!", background = 'skyblue').pack(side = LEFT, padx = 10, pady = 10) #padding
ttk.Label(root, text = "Hello, Tkinter!", background = 'orangered').pack(side = LEFT, ipadx = 10, ipady = 10) #internally padding

label.pack_forget() #label doesn't distroy. it can used later.

for widget in root.pack_slaves():
  widget.pack_configure(fill = BOTH, expand = True)
  print(widget.pack_info())

root.mainloop()