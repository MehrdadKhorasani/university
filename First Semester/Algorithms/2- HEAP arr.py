# arr = [19, 48, 10, 2, 16, 5 , 33, 32]


# def heap(arr):
#   heap_arr = []
#   for i in arr:
#     heap_arr.append(i)
#     index = heap_arr.index(i)
#     parent_index = int(heap_arr.index(i) / 2)
#     if(heap_arr[parent_index] < heap_arr[index]):
#       temp = heap_arr[index]
#       heap_arr[index] = heap_arr[parent_index]
#       heap_arr[parent_index] = temp

#   print(heap_arr)
# heap(arr)

def heapify(arr, n, i):
    smallest = i
    left = 2 * i + 1
    right = 2 * i + 2

    if left < n and arr[left] < arr[smallest]:
        smallest = left

    if right < n and arr[right] < arr[smallest]:
        smallest = right

    if smallest != i:
        arr[i], arr[smallest] = arr[smallest], arr[i]
        heapify(arr, n, smallest)

def build_min_heap(arr):
    n = len(arr)
    for i in range(n // 2 - 1, -1, -1):
        heapify(arr, n, i)

def heap_sort(arr):
    build_min_heap(arr)
    for i in range(len(arr) - 1, 0, -1):
        arr[0], arr[i] = arr[i], arr[0]
        heapify(arr, i, 0)

arr = [19, 48, 10, 2, 16, 5, 33, 32]
heap_sort(arr)
print(arr)
