def max_heapify(arr, n, i):
    largest = i
    left = 2 * i + 1
    right = 2 * i + 2

    if left < n and arr[left] > arr[largest]:
        largest = left

    if right < n and arr[right] > arr[largest]:
        largest = right

    if largest != i:
        arr[i], arr[largest] = arr[largest], arr[i]
        max_heapify(arr, n, largest)

def merge_max_heaps(heap1, heap2):
    merged_heap = heap1 + heap2
    n = len(merged_heap)
    for i in range(n // 2 - 1, -1, -1):
        max_heapify(merged_heap, n, i)
    return merged_heap

# Example usage:
heap1 = [10, 5, 6, 2]
heap2 = [12, 7, 9]

merged_heap = merge_max_heaps(heap1, heap2)
print("Merged Max Heap:", merged_heap)
