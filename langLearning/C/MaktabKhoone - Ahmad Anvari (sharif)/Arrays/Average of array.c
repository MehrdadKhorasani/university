#include <stdio.h>
#include <stdlib.h>


void Average_of_array(int array[], int length)
{
  int sum = 0;
  float result = 0;
  for(int i = 0 ; i < length; i++)
  {
    sum += array[i];
  }
  result = sum / length;
  printf("The average of your array is: %f\n", result);
  puts("\nEnd of Program!!");
}

int main()
{
  int n;
  puts("Step 1: How many element do you want for your array?");
  scanf("%d", &n);
  int array[n];
  printf("Your array with %d element created.\n", n);
  puts("\nStep 2: Fill the array:");
  for(int i = 0; i < n; i++)
  {
    printf("element %d: ", i + 1);
    scanf("%d", &array[i]);
  }
  puts("\nStep 3: The Average of your array calculated.");
  Average_of_array(array, n);
}
