#include <stdio.h>
#include <string.h>

#define MAX_STRING_LEN 20

int main() {
  int n;
  char str[MAX_STRING_LEN];
  char longestStr[MAX_STRING_LEN] = "";

  printf("Please enter the number of strings: ");
  scanf("%d", &n);

  for (int i = 0; i < n; i++) {
    printf("Please enter string %d: ", i + 1);
    scanf("%s", str);

    if (strlen(str) > strlen(longestStr)) {
        strcpy(longestStr, str);
    }
  }

  printf("The longest string in reverse is: ");
  for (int i = strlen(longestStr) - 1; i >= 0; i--) {
      printf("%c", longestStr[i]);
  }
  printf("\n");

  return 0;
}
