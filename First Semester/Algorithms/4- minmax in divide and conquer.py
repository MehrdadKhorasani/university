def min_max(arr, low, high):
    if low == high:  # If there is only one element in the array
        return arr[low], arr[low]

    elif high == low + 1:  # If there are two elements in the array
        if arr[low] < arr[high]:
            return arr[low], arr[high]
        else:
            return arr[high], arr[low]

    else:
        mid = (low + high) // 2
        min1, max1 = min_max(arr, low, mid)
        min2, max2 = min_max(arr, mid + 1, high)

        # using build-in function min() & max()
        # return min(min1, min2), max(max1, max2) 

        overall_min = min1 if min1 < min2 else min2
        overall_max = max1 if max1 > max2 else max2
        return overall_min, overall_max


arr = [12, 5, 7, 9, 4, 6]
min_num, max_num = min_max(arr, 0, len(arr) - 1)
print("Minimum number:", min_num)
print("Maximum number:", max_num)
