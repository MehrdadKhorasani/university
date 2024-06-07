#include <iostream>

using namespace std;

void knapsack(int n, float w[] ,float p[], float capacity){
    float x[3], tp = 0, u = capacity;
    int i;
    for(i = 0; i < n; i++) x[i] = 0;
    for(i = 0; i < n; i++){
        if(w[i] > u) break;
        else{
            x[i] = 1;
            tp += p[i];
            u -= w[i];
        }
    }
    if(i < n){
        x[i] = u / w[i];
        tp = tp + (x[i] * p[i]);
    }
    cout << "Result is: ";
    for(i=0;i < n; i++) cout << x[i] << " ";
    cout << "\nMax is: " << tp;
}

int main()
{
    float capacity = 20;
    int num = 3,i,j;
    float ratio[3], temp;
    float w[3] = {18,15,10};
    float p[3] = {25,24,15};
    for(i=0;i<num;i++) ratio[i] = p[i] / w[i];
    for(i=0;i<num;i++){
        for(j=i+1; j<num;j++){
            if(ratio[i] < ratio[j]){
                temp = ratio[j];
                ratio[j] = ratio[i];
                ratio[i] = temp;

                temp = w[j];
                w[j] = w[i];
                w[i] = temp;

                temp = p[j];
                p[j] = p[i];
                p[i] = temp;
            }
        }
    }
    knapsack(num,w,p,capacity);
}
