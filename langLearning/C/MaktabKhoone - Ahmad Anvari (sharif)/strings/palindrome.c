#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#define MAX_STRING_LEN 50

int main() {
  char string[MAX_STRING_LEN];
  bool isPalindrome = true;

  puts("Please Enter your string:");
  scanf("%s", string);

  int len = strlen(string);

  for(int i = 0; i < len / 2; i++)
  {
    if (string[i] != string[len - i - 1]) isPalindrome = false;
  }

  if(isPalindrome)
    printf("Your string (%s) is Palindrome!!!\n", string);
  else
    printf("Your string (%s) is Not Palondrome :((\n", string);

  return 0;
}
