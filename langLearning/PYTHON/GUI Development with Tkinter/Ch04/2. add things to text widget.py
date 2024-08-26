from tkinter import *

root = Tk()

### adding Tags & Marks & ... to the text widget

text = Text(root, width = 40, height = 10)
text.pack()
text.insert('1.0 + 2 lines', 'inserted message') 
### Tags
text.tag_add('my_tag', '1.0', '1.0 wordend')
text.tag_config('my_tag', background= 'yellow')
text.tag_remove('my_tag', '1.1', '1.3')
text.tag_ranges('my_tag') # the location of tag in text
text.tag_names() # list of tags in text + sel tag 
text.tag_names('1.0') # list of tags in first line of text
text.replace('my_tag.first', 'my_tag.last', 'That')
text.tag_delete('my_tag') #delete a tag
### Marks
text.mark_names() #1.insert 2.current
text.insert('insert', '_')
text.mark_set('my_mark', 'end')
text.mark_gravity('my_mark', 'right')
text.mark_unset('my_mark')
### Images
image = PhotoImage(file = 'python_logo.gif')
text.image_create('insert', image = image)
### another widgets, like button:
button = Button(text, text = 'click me')
text.window_create('insert', window= button)

root.mainloop()
