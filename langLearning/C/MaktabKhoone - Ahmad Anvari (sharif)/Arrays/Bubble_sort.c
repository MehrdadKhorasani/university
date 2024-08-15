#include <stdio.h>
#include <stdlib.h>
#define LENGTH 7

void bubble_sort(int array[])
{
  for(int i = 0; i < LENGTH; i++)
  {
    for(int j = 0; j < LENGTH; j++)
    {
      if (array[i] < array[j]) {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
      }
    }
  }
}

void print_array(int array[])
{
  for(int i = 0; i < LENGTH; i++)
    {
      printf("%d ", array[i]);
    }
    puts("");
}

int main()
{
  int array[LENGTH] = {3, 8, 5, 1, 6, 9, 4};
  print_array(array);
  bubble_sort(array);
  print_array(array);
  return 0;
}
