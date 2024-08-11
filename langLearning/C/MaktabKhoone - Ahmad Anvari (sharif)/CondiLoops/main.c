#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  /*
  //// IF statement
  // operators in conditions expressions: (== , != , > , < , >= , <=)
  //1.
  int age;
  puts("Please enter your age:1");
  scanf("%d", &age);
  if (age > 18) {
    printf("%d", age);
  }
  //2.
  char c = getchar();
  if (c == 'E') // ATTENTION: Use Single Quote
  {
    puts("Equal");
  }
  puts("end");
  //3.
  int age;
  puts("please enter your age");
  scanf("%d", &age);
  if (age > 18) puts("You're an adult");
  else puts("go back after you turn 18");
  //// Logical operations (! , && , ||)
  //4.
  int age;
  puts("please Enter your age: ");
  scanf("%d",&age);
  if(age <= 5) puts("You're a kid");
  else if(age > 5 && age < 18) puts("you're under legal age");
  else puts("You're an adult.");
  //5.
  char ch;
  puts("Please enter a character");
  ch = getchar();
  if (!(ch >= 'a' && ch <= 'z')) puts("your letter is uppercase");
  else puts("your letter is lowercase");
  */
  /*
  //// WHILE Loop
  //1.
  int counter = 0;
  while(counter < 10){
    printf("*");
    counter++;
  }
  printf("\n%d",counter);
  //2.
  int n;
  puts("Please enter number: ");
  scanf("%d", &n);
  int Counter = 0;
  while (Counter < n) {
    printf("%d\n", ++Counter); //=> n = 5 | 1 2 3 4 5
    //printf("%d\n", Counter++); //=> n = 5 | 0 1 2 3 4
  }
  */
  /*
  //// DO-WHILE Loop
  int sum = 0;
  int num;
  do
  {
    scanf("%d", &num);
    sum+= num;
  }
  while(num != 0);
  printf("SUM of input numbers is %d\n", sum);
  */
  /*
  //// FOR Loop
  //1.
  for(int i = 0; i < 20 ; i++)
  {
    printf("%d\n", i + 1);
  }
  //2.
  int sum = 0;
  int num;
  scanf("%d", &num);
  for(;num != 0;)
  {
    sum += num;
    scanf("%d", &num);
  }
  printf("the sum is %d\n", sum);
  */
  /*
  //// EXAMPLE FOR LOOPS:
  //1. square
  int n;
  scanf("%d", &n);
  for(int i = 0; i < n; i++)
  {
    for(int j = 0; j < n; j++)
    {
      printf("* ");
    }
    printf("\n");
  }
  //2. triangle
  int nStar;

  scanf("%d", &nStar);

  for(int i = 0; i < nStar; i++)
  {
    for(int j = 0; j < i + 1; j++)
    {
      printf("* ");
    }
    printf("\n");
  }
  //3. Max value:
  int numbers, number;
  int max = 0;
  puts("How many numbers do you want to compare?");
  scanf("%d", &numbers);
  for(int c = 0 ; c < numbers ; c++)
  {
    scanf("%d", &number);
    if(number > max) max = number;
  }
  printf("%d\n",max);
  */
  /*
  //// Break & Continue:
  //1.
  for(int i = 0; i < 10; i++)
  {
    if( i == 5) break;
    if( i == 2) continue;
    printf("%d\n", i);
  }
  //2. HOP Game
  int iter = 0;
  while (iter < 20)
  {
    if (iter % 5 == 0)
    {
      printf("h ");
      iter++;
      continue;
    }
    printf("%d ", iter);
    iter++;
  }
  */
  /*
  //// Switch-Case
  printf("Please choose your food:\n");
  puts("[1] Kabab");
  puts("[2] Ghormehsabzi");
  puts("[3] Abgoosht");
  puts("[4] Loobia Polo");
  int choosed_item;
  scanf("%d", &choosed_item);
  switch(choosed_item)
  {
  case 1:
    printf("You chose Kabab");
    break;
  case 2:
    printf("You chose Ghormehsabzi");
    break;
  case 3:
    printf("You chose Abgoosht");
    break;
  case 4:
    printf("You chose Loobia Polo");
    break;
  default:
    printf("You chose nothing John Snow!");
  }
  */
  /*
  //// CODING CHALLENGE 1
  int a,b,c;
  scanf("%d",&a);
  scanf("%d",&b);
  scanf("%d",&c);
  if(a < b + c && b < a + c && c < a + b)
    printf("Triangular");
  else
    printf("None");

  //// CODING CHALLENGE 2
  int n, m, min, max;
  puts("How many numbers do you want?");
  scanf("%d", &n);
  printf("enter your %d numbers\n", n);
  scanf("%d", &m);
  min = m;
  max = m;
  for(int c = 0 ; c < n - 1 ; c++)
  {
    scanf("%d", &m);
    if(m > max) max = m;
    else if(m < min) min = m;
  }
  printf("max number is %d\n",max);
  printf("min number is %d\n",min);

  //// CODING CHALLENGE 3
  int rows , value = 1;

  puts("How Many Rows do you want?");
  scanf("%d", &rows);

  for(int i = 0; i < rows; i++)
  {

    for (int space = 0; space <= rows - i - 1; space++)
    {
      printf(" ");
    }

    for(int j = 0; j <= i; j++)
    {
      if(j==0||i==0)
        value = 1;
      else
        value = value * (i - j + 1) / j;
      printf("%d ", value);
    }

    printf("\n");
  }

  //// CODING CHALLENGE 4
  int a, b, min;
  puts("Enter two Numbers:");
  scanf("%d", &a);
  scanf("%d", &b);

  if(a < b)
    min = a;
  else
    min = b;

  printf("Result: ");

  for(int i = 1; i <= min; i++) {
    if (a % i == 0 && b % i == 0) {
        printf("%d ", i);
    }
  }

  printf("\n");

  //// CODING CHALLENGE 5
  for(int row = 1; row <= 7; row++){
    for(int space = row; space <= 7; space++){
      printf(" ");
    }
    for(int star = 1; star <= row; star++){
      printf("* ");
    }
    printf("\n");
  }
  for(int row = 1; row <= 6; row++){
    for(int space = row; space >= 0; space--){
      printf(" ");
    }
    for(int star = 6; star >= row; star--){
      printf("* ");
    }
    printf("\n");
  }
  */
  /*
  //// STANDARD LIBRARIES
  // POW function => math library
  int base, power;
  scanf("%d", &base);
  scanf("%d", &power);
  int result = pow(base,power);
  printf("%d", result);
  // sqrt function => math library
  int a, b;
  scanf("%d", &a);
  scanf("%d", &b);
  double res = sqrt(pow(a,2) + pow(b,2));
  printf("the third side of triangle is: %lf", res);
  */
  //// Coding Challenge for LIBs
  // f(x)= sin^2(x) + cos^2(x)
  double x;
  scanf("lf",&x);
  double result = pow(sin(x),2) + pow(cos(x),2);
  printf("%lf", result);

  return 0;
}
