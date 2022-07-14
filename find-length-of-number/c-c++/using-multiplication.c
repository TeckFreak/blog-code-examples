#include <stdio.h>

int main()
{
    int num = 123456;
    int counter = 0;
    int temp = 1;

    while (temp <= num)
    {
        temp *= 10;
        counter++;
    }

    printf("%d", counter);

    return 0;
}