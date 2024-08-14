# using sqlite for database
# manage the DB:
import sqlite3

connection = sqlite3.connect("university.db")
if connection:
  print("create connection successfully")
else:
  print("Error: could not connect to database")

sql = "crete table test(name, family)"

cur = connection.cursor()
cur.execute(sql)

sql = " insert into test(name, family)"
cur.execute(sql)
connection.commit()

if connection: connection.close()