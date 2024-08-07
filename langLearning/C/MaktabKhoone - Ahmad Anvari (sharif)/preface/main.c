#include <stdio.h>
#include <stdlib.h>

int main()
{
  /*
  //// sum of two numbers:
  int number1 = 12;
  int number2 = 71;
  // unsigned or signed variables:
  unsigned int result;
  // constanst variable:
  // const int admin_name;
  // admin_name = 7;
  //error: assignment of read-only variable 'admin_name'|
  result = number1 + number2;
  printf("%d\n",result);
  */
  /*
  //// Polynomial:
  //// X = 1/2 gt^2 + V0t + x0
  const float g = 9.8;
  unsigned int t = 4;
  float v0 = 2.3;
  float x0 = 4.5;
  float x;
  x = g * t * t / 2 + v0 * t + x0;
  printf("%f", x);
  */
  /*
  //// Char:
  char my_character = 'A'; // can hold just one character
  int my_ascii = my_character;
  //represent by single quotation
  printf("The value is: %c\n", my_character); //=> A
  printf("The ascii value is: %d", my_ascii); //=> 65

  //// convert int to char:
  // int value must be less than 255, because char type cannot hold more than 254 value
  int value = 107;
  char k_character = value;
  printf("\n%c", k_character); //=> k
  */
  /*
  //// Standard Input & Output:
  //// printf learned.
  //// SCANF:
  int a;
  scanf("%d", &a);
  a *= 3;
  printf("%d",a);
  //// PUTS
  // just for a string. cannot get more than one argument:
  puts("\nHello, World!!");
  //// GETCHAR
  char word = getchar();
  printf("%c", word);
  */
  /*
  //// example: get a char from input and display the character, ascii code and the character after two:
  char character;
  puts("enter a single character:");
  character = getchar();
  printf("%c , %d , %c", character, character, character + 2);
  // <= a // => a , 97 , c  */
  /*
  //// CODING CHALLENGE 1:
  int r;
  int pi = 3;
  scanf("%d", &r);
  printf("Perimeter = %d, Area = %d\n", 2 * r * pi, r * r * pi);
  //// CODING CHALLENGE 2:
  char character;
  character = getchar();
  printf("%d\n", character);
  //// CODING CHALLENGE 3:
  char character;
  character = getchar();
  printf("%c\n", character + 32);
  */

  return 0;
}
