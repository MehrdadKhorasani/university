#include <stdio.h>
#include <stdlib.h>

int main()
{

  // example 1
  // write file:
  FILE *file_pointer;
  file_pointer = fopen("data.txt", "w");
  // file_pointer = fopen("c://users/Administrator/desktop/deskta.txt", "w");
  fprintf(file_pointer, "Hello world\n");
  fclose(file_pointer);

  // example 2
  FILE *file1;
  file1 = fopen("usernames.txt", "w");
  if (file1 == NULL) // if file doesn't open.
    printf("the file can not be opened\n");
  else
  {
    char username[50];
    printf("Please enter your name");
    scanf("%s", username);
    printf("Your name is written in file");
    fprintf(file1, "User %s is created.", username);
    fclose(file1);
  }

  //example 3
  // read file:

  FILE *file2;
  file2 = fopen("input.txt", "w");
  if (file2 == NULL)
    printf("the file can not be opened\n");
  else
  {
    fprintf(file2, "%d %d", 12, 83);
    fclose(file2);
  }

  FILE *file3;
  file3 = fopen("input.txt", "r");
  if(file3 == NULL)
  {
    printf("file can not be opened for reading");
    return 1;
  }
  int a, b;
  fscanf(file3, "%d", &a);
  fscanf(file3, "%d", &b);
  printf("a == %d and b == %d \n", a , b);
  fclose(file3);
  return 0;
}
