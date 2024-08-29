from tkinter import messagebox

messagebox.showinfo(title = 'A Friendly Message', message = 'Hello, Tkinter!') #ok

messagebox.askyesno(title = 'Hungry?', message = 'Do you want spam?') #True #False

"""
return True or false value:
1- askyesno() 2- askokcancel() 3- askretrycancel()
4- askyesnocancel 5- askquestion() 
"""

from tkinter import filedialog
filename = filedialog.askopenfile()
filename.name() # a string with the path to that file that selected

"""
Filedialog Types:
1- askdirectory() 2- asksaveasfile(mode) 3- asksaveasfilename() 
for more than one file to open:
1- askopenfile(mode) 2- askopenfiles(mode)
3- askopenfilename() 4- askopenfilenames()
"""

from tkinter import colorchooser
colorchooser.askcolor(initialcolor = '#FFFFFF')