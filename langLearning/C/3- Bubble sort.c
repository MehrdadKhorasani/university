#include <stdio.h>
#include <stdlib.h>

int main()
{
    int myArr[] = {54, 27, 15, 6, 47, 134, 69, 153, 3, 51};
    int temp;
    for(int i = 0; i < 10; i++){
        for(int j = 0; j < 10; j++){
            if (myArr[i] > myArr[j]) {
                temp = myArr[i];
                myArr[i] = myArr[j];
                myArr[j] = temp;
            }
        }
    }
    for(int i = 0 ; i <10; i++){
        printf("%d\n",myArr[i]);
    }

    return 0;
}
