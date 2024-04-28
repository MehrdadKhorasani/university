number_array = [18,23,64,8,2,195,54,33,99,118,78]

def min_max_sort(arr):
    min = number_array[0]
    max = number_array[0]
    for x in arr:
        if(x < min): min = x
        if(x > max): max = x
    print("the little: ", min, "the Big: ",max)
    
min_max_sort(number_array)