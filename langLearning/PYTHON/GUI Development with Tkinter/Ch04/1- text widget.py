from tkinter import *

root = Tk()

text = Text(root, width = 40, height = 10)
text.pack()

text.config(wrap = 'word') # three options for wrapping text: char, none & word.

##########################
### Common base formats: 
# 1. line.char
# 2. end

### Common modifiers
# 1. +/-# chars and +/-# lines
# 2. linestart, lineend, wordstart, wordend
##########################

# get text:
text.get('1.0', 'end') #all the text
text.get('1.0', '1.end') # all the text from first line
# insert one line text:
text.insert('1.0 + 2 lines', 'inserted message') # add a line with the content of "inserted message" in 3rd line (two line after the 1st line)
# insert multi-line text:
text.insert('1.0 + 2 lines lineend', ' and\nmore and\nmore...')
#delete text:
text.delete('1.0') # delete only the first character of first line
text.delete('1.0', '1.0 lineend' ) # del all the first line except last char
text.delete('1.0', '3.0 lineend + 1 chars') # del all chars in top 3 lines
# replace text:
text.replace('1.0', '1.0 lineend', 'this is the first line.')

# text states:
text.config(state = 'disabled')
text.delete('1.0', 'end' ) # doesn't do anything becase of the current state of the text widget
text.config(state = 'normal')

root.mainloop()