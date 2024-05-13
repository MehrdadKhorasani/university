def merge(arr, start, middle, end):
  n1 = middle - start + 1
  n2 = end - middle
  left = [None] * n1
  right = [None] * n2

  # Copy data to temporary arrays
  for i in range(n1):
    left[i] = arr[start + i]
  for j in range(n2):
    right[j] = arr[middle + 1 + j]

  i = 0  # index for left subarray
  j = 0  # index for right subarray
  k = start  # index to merge result back into arr

  # Merge the temporary arrays back into arr[start..end]
  while i < n1 and j < n2:
    if left[i] <= right[j]:
      arr[k] = left[i]
      i += 1
    else:
      arr[k] = right[j]
      j += 1
    k += 1

  # Copy the remaining elements of left[], if there are any
  while i < n1:
    arr[k] = left[i]
    i += 1
    k += 1

  # Copy the remaining elements of right[], if there are any
  while j < n2:
    arr[k] = right[j]
    j += 1
    k += 1


def mergeSort(arr, start, end):
  if start >= end:
    return

  middle = start + (end - start) // 2

  mergeSort(arr, start, middle)
  mergeSort(arr, middle + 1, end)

  merge(arr, start, middle, end)


array = []
for i in range(10):
  print("please type a number:")
  array.append(int(input()))

print("given array is: ", array)

length = len(array)
mergeSort(array, 0, length - 1)

print("sorted array is: ", array)
