#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_STR_LEN 50
#define NAMES_COUNT 5

void print_string_array(char strings[][MAX_STR_LEN], int strings_count);

int main()
{
  char username[10];
  scanf("%s", username); // doesn't need "&"
  for(int i = 0; i < 10; i++)
  {
    printf("%c -- %d\n", username[i], username[i]);
  }
  printf("%s\n", username);

  // char name[10] = {'M', 'e', 'h', 'r', 'd', 'a', 'd', '\0'};
  char name[10] = "Mehrdad"; //better way (using double quotation)
  printf("%s\n", name);
  //// strcpy
  char new_name[10];
  strcpy(new_name,"Mirza"); // string.h library => strcpy
  //// strlen
  int len = strlen(new_name);
  printf("%s has a length with %d chars.\n", new_name, len);

  char new_str[12] = "Creed";
  new_str[3] = 0;
  printf("%s\n", new_str); //=> Cre

  //// strcat
  char string1[MAX_STR_LEN];
  char string2[MAX_STR_LEN];

  strcpy(string1, "Hello, ");
  strcpy(string2, "World!\n");
  strcat(string1,string2);
  printf("%s", string1); //=> Hello, World!
  printf("%s", string2); //=> World!

  //// strcmp: if two strings are the same, returns 0
  if(strcmp(string1,string2) == 0) printf("Both strings are equal.\n");
  char str1[MAX_STR_LEN] = "EQU";
  char str2[MAX_STR_LEN] = "EQU";
  if(strcmp(str1,str2) == 0) printf("%s & %s\n", str1, str2); //=> EQU & EQU

  //// Authentication App
  char prompt[MAX_STR_LEN];
  char userID[MAX_STR_LEN] = "user1";
  char password[MAX_STR_LEN] = "mypassword";
  int login_seccessful = 0;
  printf("Please enter user credentials:\n");

  do
  {
    login_seccessful = 1;
    printf("%s", "username: ");
    scanf("%s", prompt);
    if(strcmp(prompt,userID) != 0) login_seccessful = 0;

    printf("%s", "Password: ");
    scanf("%s", prompt);
    if(strcmp(prompt,password) != 0) login_seccessful = 0;
  }
  while(login_seccessful == 0);
  puts("You log in successfully.");


  //// print a list of strings:
  char names[NAMES_COUNT][MAX_STR_LEN] =
  {
    "Ali",
    "Sarah",
    "William",
    "Freddy",
    "Rose"
  };

  print_string_array(names, NAMES_COUNT);

  int j;
  char selected_item[MAX_STR_LEN];
  for(int i = 1; i < NAMES_COUNT; i++)
  {
    strcpy(selected_item, names[i]);
    j = i - 1;

    while ((j >= 0) && (strcmp(selected_item, names[j]) < 0))
    {
      strcpy(names[j + 1], names[j]);
      j--;
    }
    strcpy(names[j + 1], selected_item);
  }
  puts("-----------------------------");
  print_string_array(names, NAMES_COUNT);
  return 0;
}

void print_string_array(char strings[][MAX_STR_LEN], int strings_count)
{
  for(int i = 0 ; i < strings_count; i++)
  {
    printf("%d - %s\n", i , strings[i]);
  }
}
