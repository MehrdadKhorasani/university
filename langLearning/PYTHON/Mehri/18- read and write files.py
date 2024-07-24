###################
# mode: r => read , w => write, a => append

users = ["reza rahmani\n", "zahra barati\n", "tina tehrani\n"]

myfile = open("students.txt", mode="w")

myfile.write("hello\t")
myfile.write("welcome\n")
myfile.write("Sarah Nazari\n")
myfile.write("sara rezaee\n")
myfile.writelines(users)

myfile.close()

openFile = open("students.txt")
print("open the file")
print(openFile)
#=> <_io.TextIOWrapper name='students.txt' mode='r' encoding='cp1256'>
print(openFile.read())

def writeUserInfo(user):
  with open("students.txt", "w", encoding="utf-8") as myfile:
    myfile.writelines(user)
  myfile.close()

user=["مینا قانع", "مهران حمیدی", "جواد کاظمی"]
writeUserInfo(user)

while True:
  name,family = input("نام و فامیل").strip().split()
  user.append(name + " " + family + '\n')
  exit = input("do you want to exit? y/n")
  if exit.lower() == 'y': break
writeUserInfo(user)