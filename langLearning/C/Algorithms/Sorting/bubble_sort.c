#include <stdio.h>
#include <stdlib.h>

int main()
{
  int arr[10];
  puts("Please add 10 numbers");
  for (int i = 0; i < 10; i++)
  {
    printf("number %d: ", i + 1);
    scanf("%d", &arr[i]);
  }
  for (int i = 0; i < 10; i++)
  {
    for (int j = 0; j < 10; j++)
    {
      if (arr[i] < arr[j])
      {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
      }
    }
  }
  for (int i = 0; i < 10; i++)
  {
    printf("%d ", arr[i]);
  }
}

// GEEKS FOR GEEKS REFERENCE: after you learn more about C, look the solution on that site.