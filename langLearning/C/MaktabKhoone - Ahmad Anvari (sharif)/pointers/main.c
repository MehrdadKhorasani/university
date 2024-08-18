#include <stdio.h>
#include <stdlib.h>

void func(int *arr, int size);

int main()
{

  // get the address of a value in memory
  char my_character = '=';
  char *pointer_to_my_character = &my_character;
  printf("address is %p \n",pointer_to_my_character);

  //get the value from an address in memory
  char value = 'e';
  char *ptr_value;
  ptr_value = &value;
  // printf("The value of %p is %c \n", ptr_value, *ptr_value); // THE SAME:
  printf("The value of %p is %c \n", ptr_value, (*ptr_value));

  //bad practice to create a pointer:
  char *ptr_new_bad;
  printf("%p \n", ptr_new_bad); // it sometimes doesn't return an error. and it is very bad.
  // good practice: Always initialize the pointer:
  char *ptr_new_good = NULL;
  printf("HELLO %p %c\n", ptr_new_good, (*ptr_new_good));

  // set a value to an address:
  char new_value;
  char *pointer_new_value = NULL;
  pointer_new_value = &new_value;
  (*pointer_new_value) = "N";
  printf("%c %p", new_value, pointer_new_value);

  // it impossible to set a value to a pointer:
  // int *a = 12; //segmentation fault!

  // point to another pointer:
  int a = -14;
  int *ptr_a = &a;
  int **ptr_ptr_a = &ptr_a;
  **ptr_ptr_a = 12;
  printf("a = %d", a); // a = 12


  // arrays are also pointer:
  int arr[5] = {1, 2, 3, 4, 5};
  printf("%p\n", arr); //point to the address of first index of array
  // ==
  printf("%p\n", &arr[0]);

  //example:
  int new_arr[5] = {0, 7, 9, 6, 3};
  int *p = new_arr;
  for (int i = 0 ; i < 5; i++)
  {
    printf("%d\n", *p);
    p++;
  }

  // create a array with pointers (with malloc function):
  int *a_a = malloc(4 * sizeof(int)); // == (4 * 4)
  a_a[0] = 8;
  a_a[1] = 3;
  printf("%d %d \n", a_a[0], a_a[1]); // 8 3
  // with this approach we can create arrays with dynamic memory allocation
  // in this approach, array defined in HEAP
  // in the regular approach to create arrays, arrays defined in stack
  // heap is an unmanage memory
  // IMPORTANT: remember to always free the space of heap:
  int n_of_array;
  scanf("%d", &n_of_array);
  int *nums = malloc(n_of_array * sizeof(int));

  for(int i = 0; i < n_of_array; i++) scanf("%d", &nums[i]);
  for(int i = 0; i < n_of_array; i++) printf("%d\n", nums[i]);

  free(nums); // prevent to collect garbage


  // set arr(ptr) as an argument
  int n_arr;
  scanf("%d", &n_arr);
  int *nums_n = malloc(n_arr * sizeof(int));
  for(int i = 0; i < n_arr; i++) scanf("%d", &nums_n[i]);
  func(nums_n, n_arr);
  free(nums_n);


  // Difference of making array with malloc fn and regular way (in occupy the memory):
  int arrr[10];
  printf("%d",sizeof(arrr)); //=> 40 // 10 * 4
  int *mal_arr = malloc(10 * sizeof(int));
  printf("%d",sizeof(mal_arr)); //=> 8 // returns the size that the pointer itself occupies

  return 0;
}

void func(int *arr, int size)
{
  for(int i = 0; i < size; i++) printf("%d\n", arr[i]);
}
