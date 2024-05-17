#include <stdio.h>

int partition(int array[], int start, int end) {
    if (start >= end) return;
    int pivot = array[end];
    int boundary = start - 1;
    for (int i = start; i < end; i++) {
        if (array[i] <= pivot) {
            boundary++;
            int temp = array[boundary];
            array[boundary] = array[i];
            array[i] = temp;
        }
    }
    int temp = array[boundary + 1];
    array[boundary + 1] = array[end];
    array[end] = temp;
    return boundary + 1;
}

void quick_sort(int array[], int start, int end) {
    if (start < end) {
        int pi = partition(array, start, end);
        quick_sort(array, start, pi - 1);
        quick_sort(array, pi + 1, end);
    }
}

int main() {
    int array[8] = {7, 3, 5, 9, 6, 4, 2, 1, 8};
    quick_sort(array, 0, sizeof(array) / sizeof(array[0]) - 1);
    for (int i = 0; i < sizeof(array) / sizeof(array[0]); i++) {
        printf("%d ", array[i]);
    }
    printf("\n");
    return 0;
}

