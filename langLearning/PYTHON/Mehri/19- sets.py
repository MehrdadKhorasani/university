# Sets
# another Data Structure practice23
# there is no index in sets
# عناصر تغییرناپذیر هستند
# عنصر تکراری نمی‌گیرد
# خود مجموعه تغییر پذیر است
set1 = {"hello","sara",100, True, 2.5}
print(set1) # {True, 'hello', 2.5, 100, 'sara'}
print(type(set1)) # <class 'set'>
# print(set1[1]) # ERROR:'set' object is not subscriptable

# اضافه کردن یک عنصر
set1.add(420)
set1.add("nima")
print(set1) # {'hello', True, 2.5, 100, 420, 'nima', 'sara'}
# there is no order in sets

# اضافه کردن مجموعه
set1.update({1,2,3,4})
print(set1) # {True, 2.5, 2, 100, 420, 3, 4, 'sara', 'nima', 'hello'}
# there is no 1 because of True => True == 1

# اضافه کردن مجموعه با لیست
set1.update(["nima","hello","test"])
print(set1) # {True, 2.5, 2, 100, 420, 3, 4, 'hello', 'test', 'nima', 'sara'}

#  اضافه کردن مجموعه با تاپل
set1.update((80,3))
print(set1) #{True, 2.5, 'nima', 100, 420, 2, 3, 'sara', 4, 'test', 80, 'hello'}

# delete a value randomely!!!!
print(set1.pop()) # True

# delete the whole set:
# del set1
# print(set1) # ERRORR: name 'set1' is not defined

# copy a set to prevent the mutation
copy_set = set1.copy()

# clear the set:
set1.clear()
print(set1) # set()

# do not do this:
set2 = {}
print(set2) # {}
print(type(set2)) # <class 'dict'>
# Do this:
set3 = set()
print(set3) # set()
print(type(set3)) # <class 'set'>

set3 = set("hello")
print(set3) # {'l', 'o', 'h', 'e'}

set4 = set(range(1,10))
print(set4) # {1, 2, 3, 4, 5, 6, 7, 8, 9}


# union
s_1 = {1,2,3,4,5,6}
s_2 = {10,20,5,6}
result = s_1.union(s_2)
print(result) # {1, 2, 3, 4, 5, 6, 10, 20}

# difference
result2 = s_1.difference(s_2)
print(result2) # {1, 2, 3, 4}
result3 = s_2.difference(s_1)
print(result3) # {10, 20}

#discard
s_1.discard(2)
print(s_1) # {1, 3, 4, 5, 6}
s_1.discard(20) # doesn't return an error
print(s_1) # {1, 3, 4, 5, 6}

# remove
# s_1.remove("5")
# print(s_1) # return an error

for item in s_1:
  print(item)