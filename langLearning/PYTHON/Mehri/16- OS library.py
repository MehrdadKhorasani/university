###### OS library:
import os
print(os.name) # nt

print(os.getcwd()) # C:\Users\Administrator\Desktop

if not os.path.exists("new_folder"):
  os.mkdir("new_folder")
print(os.path.exists("new_folder")) # True

print(os.curdir) # . # means root of project

path = r"new_folder\\"
new_path = os.path.join(path,"test")
print(new_path) # new_folder\\test
if not os.path.exists(new_path):
  os.mkdir(new_path)

os.chdir("new_folder")
print(os.getcwd()) # C:\Users\Administrator\Desktop\new_folder
os.chdir("test")
print(os.getcwd()) # C:\Users\Administrator\Desktop\new_folder\test

# os.chdir("new_folder")
if os.path.exists('test'):
  os.chdir("test")
  os.mkdir("user")
  print("create file successfully")
if os.getcwd() == "new_folder/test":
  if os.path.exist("user"):
    os.rmdir("test")

# listing the directory
print(os.listdir()) 

for item in os.listdir():
  if item.endswith(".py"): print(item)

try:
  os.mkdir("user1")
  os.chdir("user1")
  print(os.getcwd()) # C:\Users\Administrator\Desktop\new_folder\test\user1 
  print("create folder and change te dircetory")
except IOError as e:
  print(f"error: {e}")
except FileNotFoundError as e:
  print(f"error: {e}")


try:
  # os.chdir("../") #change dir
  print(os.getcwd())
  os.rmdir("user1")
  print("user1 folder deleted")
except IOError as e:
  print(f"error: {e}")
except FileNotFoundError as e:
  print(f"error: {e}")

os.chdir("../") #change dir
if os.path.exists("test"):
  os.rename("test","file")
  print("rename dir")
