#include <stdio.h>
#include <stdlib.h>

#define ROW_COUNT 3
#define COL_COUNT 5

//int main()
//{
  /*
  int numbers[3];
  numbers[0] = 12;
  numbers[1] = -3;
  numbers[2] = 8;
  int offset = 5;
  numbers[2] = offset + numbers[1];
  printf("%d\n",numbers[2]); //=> 2
  scanf("%d", &numbers[0]);
  printf("%d\n", numbers[0]);
  */

  /*
  int students = 5;
  float students_marks[students];
  float marks_sum = 0;
  for(int i = 0; i < students; i++)
  {
    printf("Please enter the mark of student %d\n", i);
    scanf("%f", &students_marks[i]);
  }
  for (int i = 0; i < students; i++)
  {
    marks_sum += students_marks[i];
  }
  marks_sum /= students;
  printf("The sum of scores is: %f\n", marks_sum);

  for(int i = 0; i < students; i++)
  {
    if(students_marks[i] > marks_sum)
    {
      printf("student num. %d is above the average of %f with the %f score\n", i, marks_sum, students_marks[i]);
    }
  }
  */

  /*
  // initialize the values of arrays
  int numbers[3] = {5, 8 , 12};
  printf("%d\n", numbers[0]); //=> 5
  int numbers_2[3] = {9};
  for(int i = 0; i < 3; i++) printf("%d ", numbers_2[i]); // 9 0 0 => it said 9 9 9 but!!!
  int numbers_3[] = {1,2,3,4};
  for(int i = 0; i < 4; i++) printf("%d ", numbers_3[i]); // 1 2 3 4
  */
  //return 0;
//}

/*
//// functions with arrays:
// variables are call by value
// arrays are call by reference
void print_array(int array[], int size_of_array);
void increament_array(int array[], int size_of_array);
void insertion_sort(int array[], int size_of_array);
int main()
{
  const int array_size = 5;
  int array[array_size];
  for (int i = 0; i < array_size; i++)
  {
    scanf("%d", &array[i]);
  }
  print_array(array, array_size);
  // increament_array(array,array_size);
  insertion_sort(array,array_size);
  print_array(array, array_size);
  // after that increasment_array called, the values are difference, although the increament_array doesn't return anything! (call by reference)
  return 0;
}
void print_array(int array[], int size_of_array)
{
  for(int i = 0; i < size_of_array; i++)
  {
    printf("%d ", array[i]);
  }
  puts("");
}
void increament_array(int array[], int size_of_array)
{
  for(int i=0; i < size_of_array; i++)
  {
    array[i]++;
  }
}
void insertion_sort(int array[], int size_of_array)
{
  int selected_item, j;
  for (int i = 1 ; i < size_of_array; i++)
  {
    selected_item = array[i];
    j = i - 1;
    while((j >= 0) && (selected_item < array[j]))
    {
      array[j + 1] = array[j];
      j --;
    }
    array[j + 1] = selected_item;
  }
}
*/

//// two dimensional array
void print_array(int array[][COL_COUNT])
{
  for (int i = 0; i < ROW_COUNT; i++)
  {
    for(int j = 0; j < COL_COUNT; j++)
    {
      printf("%d ", array[i][j]);
    }
    puts("");
  }
}
int main()
{
  int numbers[2][3];
  for (int i=0; i < 2; i++)
  {
    for (int j=0; j < 3; j++)
    {
      printf("enter the index of: [%d][%d]", i , j);
      scanf("%d", &numbers[i][j]);
    }
  }
  for (int i=0; i < 2; i++)
  {
    for (int j=0; j < 3; j++)
    {
      printf("%d ", numbers[i][j]);
    }
    puts("");
  }

  //// initialize the values fro 2d arrays:
  int nums[2][4] = {{3,2,1,5},{8,4,6,7}};
  // int nums[2][4] = {3,2,1,5,8,4,6,7}; // same result
  for (int i=0; i < 2; i++)
  {
    for (int j=0; j < 4; j++)
    {
      printf("%d ", nums[i][j]);
    }
    puts("");
  }

  int array_for_export[ROW_COUNT][COL_COUNT] = {{18,9,3,15,14},{1},{14,8,2,6}};
  print_array(array_for_export);

  return 0;
}
