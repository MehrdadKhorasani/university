#include <stdio.h>
#include <stdlib.h>
#define COUNT 10
#define GREETING "Type a positive value: "
int main()
{
    printf(GREETING);
    for(int a=0;a<COUNT;a++){
        printf("I must do this %d times\n", COUNT);
        if(a==9)
            break;
    }
    return 0;
}
