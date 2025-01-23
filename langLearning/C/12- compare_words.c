#include <stdio.h>

int compareWords(char word[20], int length, char userWord[20])
{
	for (int i = 0; i < length; i++)
	{
		if (word[i] != userWord[i])
		{
				return 3;
		}
	}
	return 2;
}

int main()
{
	char word[] = "Dennis";
	// printf("%s", word);
	int length = sizeof(word) / sizeof(word[0]);
	char userWord[20];
	printf("Please write your word:\n");
	scanf("%s", userWord);
	printf("%s\n", userWord);
	int result = compareWords(word, length, userWord);
	if (result == 2) printf("TRUE\n");
	else if (result == 3) printf("FALSE\n");
}
