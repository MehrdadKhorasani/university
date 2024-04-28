
#include <stdio.h>

int main()
{
	int num_arr[] = { 8,32,28,41,19,97,52,67,87,3,71 };
	int length = sizeof(num_arr) / sizeof(num_arr[0]);
	int min_num = num_arr[0];
	int max_num = num_arr[0];
	for (int i = 0; i < length; i++) {
		if (min_num > num_arr[i]) min_num = num_arr[i];
		if(max_num < num_arr[i]) max_num = num_arr[i];
	}
	printf("%d\n", min_num);
	printf("%d\n", max_num);
}

