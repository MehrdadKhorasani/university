array =  [2,14,6,78,95,32,546,5122,658,32,6548,326325,1,6465,15615,95965,35594984]

length = len(array)
bigger = 0
stalinArray = []

for i in range(length):
  if array[i] >= bigger:
    bigger = array[i]
    stalinArray.append(array[i])

print(stalinArray)