#include <stdio.h>
#include<math.h>
#include<string.h>

int main()
{
    int number = 123456;
    char str[20];

    // sprintf also returns the size of number.
    sprintf(str, "%d", number);

    printf("%d", strlen(str));

    return 0;
}