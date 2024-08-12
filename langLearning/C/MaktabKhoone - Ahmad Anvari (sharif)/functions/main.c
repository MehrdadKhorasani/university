#include <stdio.h>
#include <stdlib.h>
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

int main()
{

  return 0;
}
