# Insertion Sort

def insertionSort(arr):
    for i in range(1, len(arr)):
        key = arr[i]
        j = i-1
        while j >= 0 and key < arr[j] :
            arr[j + 1] = arr[j]
            j -= 1
        arr[j + 1] = key

array = [9, 3, 7, 1, 5, 6, 2, 4, 8]
insertionSort(array)
print(array)

