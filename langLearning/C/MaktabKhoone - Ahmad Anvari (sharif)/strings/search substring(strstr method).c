#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_STRING_LEN 50

int main() {
  char string1[MAX_STRING_LEN];
  char string2[MAX_STRING_LEN];

  puts("Please Enter first string:");
  scanf("%s", string1);
  puts("Please Enter second string:");
  scanf("%s", string2);

  if(strstr(string1,string2) != NULL)
    printf("Yes");
  else
    printf("No");

  return 0;
}
