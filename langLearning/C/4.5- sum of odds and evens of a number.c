#include <stdio.h>

int main()
{
    int i, num, odd_sum = 0, even_sum = 0;

    printf("what is your number?\n");
    scanf("%d", &num);

    for(i=1; i < num; i++){
        if(i % 2 == 0) {
            even_sum += i;
        }
        else odd_sum += i;
    }
    printf("sum of odd numbers in %d: %d \n", num, odd_sum);
    printf("sum of odd numbers in %d: %d \n", num, even_sum);

    return 0;
}
