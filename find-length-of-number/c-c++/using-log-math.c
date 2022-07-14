#include <stdio.h>
#include <math.h>

int main()
{
    int num = 123456;

    double logValue = log10(num);
    int finalLength = (int)floor(logValue) + 1;

    printf("%d", finalLength);

    return 0;
}