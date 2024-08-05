#include <stdio.h>
#include <stdlib.h>

int main()
{
  // INTEGERS & PRINT:
  int a;
  a = 5;
  printf("%d",a); // print a value from a variable (with integer type)

  // OPERATION & SIMPLE MATH:
  int result = 5 + 2 * 2;
  printf("\nresult is: %d", result); // * has more priority than +

  // UNINITIAL VARIABLES:
  int x;
  int y =  x + 5 + 180;
  printf("\n%d", y); // 185 => x is uninitialized and so it is 0

  // FLOATS:
  float firstNumber, secondNumber;
  firstNumber = 10.5;
  secondNumber = 18.2;
  float sum = firstNumber + secondNumber;
  float subtract = firstNumber - secondNumber;
  float multiply = firstNumber * secondNumber;
  float division = firstNumber / secondNumber;
  printf("\n%f", sum); // 28.700001
  printf("\n%f", subtract); // -7.700001
  printf("\n%f", multiply); // 191.100006
  printf("\n%f", division); // 0.576923
  float result2 = 4 * 1.1;
  printf("\n%f", result2); // 4.400000

  // POLYNOMIAL:
  float p = 3.22;
  // float z = p ^ 3 * 5 + 4 * p - 7;
  float z = (p * p * p) * 5 + 4 * p - 7;
  printf("\n%f", z);

  // INPUT:
  int my_number;
  printf("\nPlease type my special number: ");
  scanf("%d", &my_number);
  printf("\nMy special number is \"%d\". congrats!!!", my_number);

  return 0;
}
