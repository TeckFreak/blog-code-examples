#include <stdio.h>

int main()
{
    int num = 123456;
    int counter = 0;

    while (num > 0)
    {
        num /= 10;
        counter++;
    }

    printf("%d", counter);

    return 0;
}