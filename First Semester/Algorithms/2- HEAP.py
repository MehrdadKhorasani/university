arr = [23,19,18,5,9,13,11,3,0]

def heap(arr):
    arr.append(21)
    for x in arr:
        index = arr.index(21)
        parentIndex = int(index / 2)    
        if (arr[index] > arr[parentIndex]):
            temp = arr[index]
            arr[index] =arr[parentIndex]
            arr[parentIndex] = temp
            print(arr)
       
heap(arr)
