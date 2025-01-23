#include <stdio.h>

int main()
{
	int n, rev = 0, temp, rem;
	printf("Enter a number:");
	scanf("%d", &n);

	temp = n;
	while(n>0)
	{
		rem = n % 10;
		n = n / 10;
		rev = rev * 10 + rem;
	}

	if(temp == rev) printf("The number %d is a Palendrome",temp);
	else printf("The number %d is not Palendrome",temp);

	return 0;
}
