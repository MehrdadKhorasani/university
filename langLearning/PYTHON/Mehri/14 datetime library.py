##### datetime library
import datetime
date = datetime.datetime.now()
print(date) # 2024-07-22 18:42:58.725203
print(date.year) # 2024
print(date.day) # 22 
print(date.month) # 7 
print(date.hour) # 18
print(date.minute) # 42
print(date.second) # 58

newDate = datetime.date(2023,12,2) # 2023-12-02
print(newDate)

time = datetime.time(10,25,5)
print(time) # 10:25:05
time = datetime.time(10,25,50,20000)
print(time) # 10:25:50.020000
print(time.hour) # 10
print(time.minute) # 25
print(time.second) # 50
print(time.microsecond) # 20000

time2 = datetime.date.fromtimestamp(0)
print(time2) # 1970-01-01
time2 = datetime.date.fromtimestamp(250000000)
print(time2) # 1977-12-03

newformat = date.strftime("%H:%M:%S")
print(newformat) # 18:53:05
newformat = date.strftime("%D - %H:%M:%S")
print(newformat) # 07/22/24 - 18:55:55
newformat = date.strftime("%d/%m/%Y, %H:%M:%S")
print(newformat) # 22/07/2024, 18:57:02
newformat = date.strftime("%d/%m/%y, %H:%M:%S")
print(newformat) # 22/07/24, 18:59:23
# so much more formats - check the docs

str1 = "2020"
print(datetime.datetime.strptime(str1, "%Y"))

d1 = datetime.timedelta(weeks=2,days=1,hours=10,seconds=53)
print(d1) # 15 days, 10:00:53
d2 = datetime.timedelta(weeks=21,days=1,hours=10,minutes=18)
print(d2) # 148 days, 10:18:00
d3 = d2 - d1
print(d3) # 133 days, 0:17:07
print(d1.total_seconds()) # 1332053.0
d4 = d1.total_seconds()
print(datetime.datetime.fromtimestamp(d4)) # 1970-01-16 13:30:53