#include <stdio.h>

int main()
{
	int n, rem, rev = 0;
	printf("enter a number");
	scanf("%d",&n);

	while(n>0)
	{
		rem = n % 10;
		n = n/10;
		rev = rev * 10 + rem;
	}
	printf("\nThe reverserd number:%d",rev);
	return 0;
}
