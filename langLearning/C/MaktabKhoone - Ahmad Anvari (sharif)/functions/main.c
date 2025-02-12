#include <stdio.h>
#include <stdlib.h>
#include <limits.h>


/*
//// SELF CODING CHALLENGE: SUM FUNCTION:
int sum(nums){
  int num, result;
  int ac[10] = {};
  for(int i = 1; i <= nums; i++){
    printf("number %d of %d \n", i, nums);
    scanf("%d", &num);
    ac[i - 1] = num;
  }
  for(int i = 1; i <= nums; i++){
    result += ac[i - 1];
  }
  return result;
}

int main()
{
  int nums;
  puts("How many numbers do you want to sum? (1-10)");
  scanf("%d", &nums);
  if(nums > 10) return;
  int result = sum(nums);
  printf("The sums of your numbers is: %d", result);
  return 0;
}
*/
/*
//// fn for compare 3 integer for max value:
int max3(int value1, int value2, int value3){
  if(value1 > value2)
  {
    if(value1 > value3){
      return value1;
    }
    else
    {
      return value3;
    }
  }
  else
  {
    if(value2 > value3)
    {
      return value2;
    }
    else
    {
      return value3;
    }
  }
}
int main()
{
  int w1, w2, w3;
  int h1, h2, h3;
  scanf("%d %d %d", &w1, &w2, &w3); //get 3 weight from user
  scanf("%d %d %d", &h1, &h2, &h3); //get 3 height from user
  int max_w = max3(w1,w2,w3); // calculate max weight
  int max_h = max3(h1,h2,h3); // calculate max height
  printf("max width: %d \n max height: %d", max_w, max_h);
  return 0;
}

*/
/*
void new_function(){
  int counter = 0;
  counter++;
  printf("%d\n",counter);
}
int main()
{
  // printf("%d",counter); //ERROR: scoping error
  new_function(); //=> 1
  new_function(); //=> 1
  // every time new_function called, a new variable (called counter) is made in stack.
  return 0;
}
*/

/*
//// find the max value and the second max value:
// using GLOBAL VARIABLE (NOT recommended):
int max;
int max2;
// type function names to prevent hoisting problem
void init_variables();
void input_and_max();
void print();

int main()
{
  init_variables();
  input_and_max();
  print();
  return 0;
}

void print()
{
  printf("the first max is %d and the second one is %d", max, max2);
}

void input_and_max()
{
  int n;
  scanf("%d", &n);
  for(int i = 0; i < n; i++)
  {
    int num;
    scanf("%d", &num);
    if(num > max2)
    {
      if(num > max)
      {
        max = num;
      }
      else
      {
        max2 = num;
      }
    }
  }
}

void init_variables()
{
  // get the value from <limit.h> library
  max = INT_MIN;
  max2 = INT_MIN;
}
*/

/*
//// SWAP
void swap(int x , int y);

int main()
{
  int x , y;
  puts("add two numbers: ");
  scanf("%d", &x);
  scanf("%d", &y);
  printf("1) x = %d and y = %d\n", x , y); // 1) x = 12 and y = 32
  swap(x,y);
  printf("4) x = %d and y = %d\n", x , y); // 4) x = 12 and y = 32
  return 0;
}

void swap(int x , int y)
{
  printf("2) x = %d and y = %d\n", x , y); // 2) x = 12 and y = 32
  int temp = x;
  x = y;
  y = temp;
  printf("3) x = %d and y = %d\n", x , y); // 3) x = 32 and y = 12
}
*/

/*
//// STORAGE CLASSES
// auto != static
void count();

int main()
{
  count(); // counter is 1
           // counter two is 1
  count(); // counter is 1
           // counter two is 2
  return 0;
}

void count()
{
  int counter = 0; // auto type: also can write this way: auto int counter = 0;
  static counter_two = 0; // static type
  counter++;
  counter_two++;
  printf("counter is %d\n", counter);
  printf("counter two is %d\n", counter_two);
}
*/

/*
//// Recursive Functions
void f(int n)
{
  if(n < 0) return;
  printf("Recursive Functions: n is %d\n", n);
  f(n-1);

}

// multiply first arg in second arg:
int recursive_mul(int a, int b)
{
  if (a > 1)
  {
    return b + recursive_mul(a - 1, b);
  }
  else
  {
    return b;
  }
}

// factoriel:
int factoriel(int n)
{
  if ((n == 1) || (n == 0))
  {
    return 1;
  }
  return n * factoriel(n - 1);
}

// power
int power_fn(int base, int power)
{
  if (power == 0) return 1;
    return base * power_fn(base,power - 1);
}

int main()
{
  //1
  // f(12);
  //2
  // int mul_result = recursive_mul(3, 4);
  // printf("Recursive res: %d", mul_result);
  //3
  // printf("%d\n", factoriel(4));
  //4
  printf("%d\n", power_fn(2,3));
  return 0;
}
*/

/*
//// CODING CHALLENGE: FIBONACCI SEQUENCE

int fibonacci(int n) {
  if (n <= 0)
    return -1;
  else if (n == 1)
    return 1;
  else if (n == 2)
    return 1;
  else
    return fibonacci(n-1) + fibonacci(n-2);
}

int main() {
  int n;

  puts("Enter an integer number: ");
  scanf("%d", &n);

  int result = fibonacci(n);
  if (result == -1)
    printf("The number must be greater than 0\n");
  else
    printf("The %dth Fibonacci number: %d\n", n, result);

  return 0;
}
*/

/*
//// CODING CHALLENGE:
int print_reverse_numbers();
int main()
{
  puts("please enter a number");
  print_reverse_numbers();

  return 0;
}

int print_reverse_numbers()
{
  int number;
  scanf("%d", &number);
  if (number == -1) return;

  print_reverse_numbers();

  printf("%d\n", number);

}
*/
