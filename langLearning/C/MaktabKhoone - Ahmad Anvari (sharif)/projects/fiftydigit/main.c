#include <stdio.h>
#include <string.h>

#define MAX_DIGITS 50

// A simpler solution was to use the GMP library (GNU Multiple Precision Arithmetic Library).
// But because it was not mentioned in the exercise that we can use an external library, I did not use GMP.

void multiply(char num1[], char num2[], char result[]) {
    int len1 = strlen(num1);
    int len2 = strlen(num2);
    int resultLen = len1 + len2;

    int tempResult[resultLen];
    memset(tempResult, 0, sizeof(tempResult));

    for (int i = len1 - 1; i >= 0; i--) {
        for (int j = len2 - 1; j >= 0; j--) {
            int mul = (num1[i] - '0') * (num2[j] - '0');
            int sum = mul + tempResult[i + j + 1];

            tempResult[i + j] += sum / 10;
            tempResult[i + j + 1] = sum % 10;
        }
    }

    int i = 0;
    while (i < resultLen && tempResult[i] == 0) {
        i++;
    }

    if (i == resultLen) {
        strcpy(result, "0");
    } else {
        int k = 0;
        while (i < resultLen) {
            result[k++] = tempResult[i++] + '0';
        }
        result[k] = '\0';
    }
}

int compare(char num1[], char num2[]) {
    int len1 = strlen(num1);
    int len2 = strlen(num2);

    if (len1 > len2) return 1;
    if (len1 < len2) return -1;

    for (int i = 0; i < len1; i++) {
        if (num1[i] > num2[i]) return 1;
        if (num1[i] < num2[i]) return -1;
    }

    return 0;
}

void subtract(char num1[], char num2[], char result[]) {
    int len1 = strlen(num1);
    int len2 = strlen(num2);
    int carry = 0;

    for (int i = 0; i < len1; i++) {
        int sub = (num1[len1 - 1 - i] - '0') - (i < len2 ? (num2[len2 - 1 - i] - '0') : 0) - carry;
        if (sub < 0) {
            sub += 10;
            carry = 1;
        } else {
            carry = 0;
        }
        result[len1 - 1 - i] = sub + '0';
    }

    result[len1] = '\0';

    int startIndex = 0;
    while (result[startIndex] == '0' && startIndex < len1 - 1) {
        startIndex++;
    }
    memmove(result, result + startIndex, strlen(result) - startIndex + 1);
}

void divide(char num1[], char num2[], char result[]) {
    if (strcmp(num2, "0") == 0) {
        strcpy(result, "Undefined"); // Division by zero error
        return;
    }

    char quotient[MAX_DIGITS * 2] = {0};
    char remainder[MAX_DIGITS * 2] = {0};

    strcpy(remainder, "0");
    int len1 = strlen(num1);
    int len2 = strlen(num2);
    int quotientIndex = 0;

    for (int i = 0; i < len1; i++) {
        int lenRemainder = strlen(remainder);
        remainder[lenRemainder] = num1[i];
        remainder[lenRemainder + 1] = '\0';

        int quotientDigit = 0;
        while (compare(remainder, num2) >= 0) {
            subtract(remainder, num2, remainder);
            quotientDigit++;
        }

        quotient[quotientIndex++] = quotientDigit + '0';
    }

    quotient[quotientIndex] = '\0';

    if (strlen(remainder) > 1 && strcmp(remainder, "0") != 0) {
        quotient[quotientIndex++] = '.';
        int decimalPlaces = 0;

        while (compare(remainder, "0") > 0 && decimalPlaces < MAX_DIGITS) {
            int lenRemainder = strlen(remainder);
            remainder[lenRemainder] = '0';
            remainder[lenRemainder + 1] = '\0';

            int quotientDigit = 0;
            while (compare(remainder, num2) >= 0) {
                subtract(remainder, num2, remainder);
                quotientDigit++;
            }

            quotient[quotientIndex++] = quotientDigit + '0';
            decimalPlaces++;
        }
    }

    quotient[quotientIndex] = '\0';

    int remainderIndex = 0;
    while (quotient[remainderIndex] == '0' && remainderIndex < len1 - 1) {
        remainderIndex++;
    }

    strcpy(result, &quotient[remainderIndex]);
}

int main() {
    char num1[MAX_DIGITS + 1] = "81032052209205198898115319280947076523714292376381";
    char num2[MAX_DIGITS + 1] = "16940855065813062592482254759430446649741777733604";

    char resultMultiplication[MAX_DIGITS * 2 + 1];
    char resultDivision[MAX_DIGITS * 2 + 1];

    multiply(num1, num2, resultMultiplication);
    divide(num1, num2, resultDivision);

    printf("Multiplication: %s\n", resultMultiplication);
    printf("Division: %s\n", resultDivision);

    return 0;
}
