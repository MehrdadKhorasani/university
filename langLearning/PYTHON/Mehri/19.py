import os
os.getcwd()
if os.path.exists("students.txt"):
  openFile = open("students.txt", mode= 'r',encoding="utf-8")

  print("pointer:", openFile.tell())
  for line in openFile:
    print(line,end="")

  openFile.seek(0)
  print(openFile.readline())
  print("pointer:", openFile.tell())

  openFile.close()