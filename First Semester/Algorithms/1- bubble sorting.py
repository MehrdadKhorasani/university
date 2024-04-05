import random

def generate_random_numbers(num):
    random_numbers = [random.randint(1, 1000) for _ in range(num)]
    return random_numbers

def bubble_sort(arr):
    n = len(arr)
    for i in range(n):
        for j in range(0, n-i-1):
            if arr[j] > arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]

if __name__ == "__main__":
    num_of_numbers = 500
    random_numbers = generate_random_numbers(num_of_numbers)
    print("Random numbers before sorting:")
    print(random_numbers)

    bubble_sort(random_numbers)

    print("\nRandom numbers after sorting using Bubble Sort:")
    print(random_numbers)
