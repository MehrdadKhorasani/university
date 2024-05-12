#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;
    printf("What is your number?\n");
    scanf("%d", &n);

    if(n % 2 == 0){
        printf("the Number %d is an even Number!", n);
    } else {
        printf("the Number %d is an odd Number!", n);
    }

    return 0;
}
