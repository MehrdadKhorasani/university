from tkinter import *
from tkinter import ttk
import os

root = Tk()

treeview = ttk.Treeview(root)
treeview.pack()

treeview.insert('', '0', 'item1', text="First Item")
treeview.insert('', '1', 'item2', text="Second Item")
treeview.insert('', 'end', 'item3', text="Third Item")

script_dir = os.path.dirname(os.path.abspath(__file__))
parent_dir = os.path.abspath(os.path.join(script_dir, os.pardir))
image_path = os.path.join(parent_dir, 'python_logo.gif')

logo = PhotoImage(file=image_path).subsample(10, 10)
treeview.image = logo  

treeview.insert('item2', 'end', 'python', text='Python', image=logo)

treeview.config(height = 5)
treeview.move('item2', 'item1', 'end')

treeview.item('item1', open = True)
treeview.item('item1', 'open') #True
treeview.detach('item3')
treeview.move('item3', 'item2', '0')

treeview.delete('item3')

treeview.config(columns = ('version'))
treeview.column('version', width = 50, anchor='center')
treeview.column('#0', width = 150)
treeview.heading('version', text= 'Version')
treeview.set('python', 'version', '3.4.1')
treeview.item('python', tags= ('software'))
treeview.tag_configure('software', background='yellow')

def callback(event):
  print(treeview.selection())

treeview.bind('<<TreeviewSelect>>', callback)

treeview.config(selectmode= 'browse')
treeview.config(selectmode= 'none')

treeview.selection_add('python')
treeview.selection_remove('python')
treeview.selection_toggle('python')

root.mainloop()
