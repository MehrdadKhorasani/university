##### Dictionary data structure
dict1 = {
  "name": "Ali",
  "family": "Kamali",
  "age": 25,
  "mobile": 989360398561,
  "city": "Tehran"
}

# values can be all the data types.
# keys should be data types that can not be changed: string - number - tuple
print(dict1)
# {'name': 'Ali', 'family': 'Kamali', 'age': 25, 'mobile': 989360398561, 'city': 'Tehran'}
print(dict1['name']) # Ali

dict2 = {
  "name": "Ali",
  "name": "Sara",
  "age": 25,
}
print(dict2['name']) # Sara

dict3 = {1: "one", 2: "two", 3: "three"}
print(dict3[2]) # two

dict4 = {(1,):"sara",(1,2):"nima", (4,1,7):"limoo"}
print(dict4[(1,)]) # sara

dict5 = dict(a="ali", b="bita", k = "kamran", ali= 125, x="kin")
print(dict5)
# {'a': 'ali', 'b': 'bita', 'k': 'kamran', 'ali': 125, 'x': 'kin'}
print(type(dict5)) # <class 'dict'>

# print keys from a dict
# 1
for key in dict5:
  print(key) # a b k ali x
# 2  
for key in dict5.keys():
  print(key) # ali bita kamran 125 kin

# print values from a dict
# 1
for value in dict5:
  print(dict5[value]) # ali bita kamran 125 kin
# 2
for key in dict5.values():
  print(key) # a b k ali x

for key, value in dict5.items():
  print(key, "=" , value)
  """
    a = ali
    b = bita
    k = kamran
    ali = 125
    x = kin
  """

students = {
  1: {"name": "ali", "family": "kamrani", "age": 23},
  2: {"name": "sara", "family": "lorestani", "age": 18},
  3: {"name": "mahdi", "family": "sibi", "age": 92},
  4: {"name": "jafar", "family": "divi", "age": 24},
  5: {"name": "mina", "family": "mini", "age": 3},
}

for k,v in students.items():
  print(f"{k}) {v["name"]} {v["family"]}")
  """
    1) ali kamrani
    2) sara lorestani
    3) mahdi sibi
    4) jafar divi
    5) mina mini
  """

for k,v in students.items():
  for value in v.values():
    print(value,end=" ")
  print()
  """
    ali kamrani 23
    sara lorestani 18
    mahdi sibi 92
    jafar divi 24
    mina mini 3
  """

### update method:
dict6 = {}
dict6.update({"a":"python","b":548})
print(dict6) # {'a': 'python', 'b': 548}
dict6.update(dict5)
print(dict6) # {'a': 'ali', 'b': 'bita', 'k': 'kamran', 'ali': 125, 'x': 'kin'}

# exercise:
'''
cities = {}
for i in range(1,6):
  city = input("Enter a city name: ")
  if city.replace(" ","").isalpha():
    cities.update({i:city})
print(cities)
# {1: 'mashhad', 2: 'tehran', 3: 'karaj', 4: 'yazd', 5: 'shiraz'} 
'''

### pop method:
print(dict6.pop("a")) # ali
print(dict6) # {'b': 'bita', 'k': 'kamran', 'ali': 125, 'x': 'kin'}
print(dict6.pop("firstName","not found")) #not found
print(dict6.pop("b","not found")) # bita

### popitem method:
print(dict6.popitem()) # ('x', 'kin')

### get method:
print(dict6.get("k")) # kamran

### copy method:
dict7 = dict6.copy()
print(dict7) # {'k': 'kamran', 'ali': 125}

### clear method:
dict6.clear()
print(dict6) # {}