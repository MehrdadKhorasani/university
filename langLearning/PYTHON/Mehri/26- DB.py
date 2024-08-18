import sqlite3
from sqlite3 import Error

def createConnection(db_name):
  connection = None

  try:
    connection = sqlite3.connect(db_name)
  except Error as e:
    print("Connection error:", e)
  finally:
    return connection
  

def createStudentTable(connection):
  sql = "create table if not exists student(id integer primary key , name text, family text,\
     average real)"
  cur = connection.cursor()
  try:
    cur.execute(sql)
  except Error as e: 
    print("Create table error: ", e) 
  
def addStudent(connection):
  data = 0
  try:
    id = input("id:")
    name = input("Enter student name:").strip().isalpha()
    family = input("Enter student family:").strip().isalpha()
    average = float(input("Enter student average"))
  except ValueError as e:
    print(e)
  else:
    cursor = connection.cursor()
    data = (id, name,family,average)
    sql = "insert into student() values(?,?,?,?)"
    cursor.execute(sql, data)

connection = createConnection("university.db")
if connection != None:
  createStudentTable(connection)
  addStudent(connection)