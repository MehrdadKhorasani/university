array = [91,42,61,2,15,37,94,54,21]

def quick_sort(arr):
  if len(arr) < 2:
    return arr
  return partition(arr,0, len(arr) - 1)

def partition(array,start,end):
  if start >= end: return
  pivot = end
  boundary = start
  
  for i in range(start,end):
    if array[i] <= array[pivot]:
      array[boundary],array[i] = array[i],array[boundary]
      boundary += 1
  array[boundary],array[end] = array[end],array[boundary]
  
  partition(array,start,boundary - 1)
  partition(array,boundary + 1,end)
  return array

result = quick_sort(array)
print(result)