#include <stdio.h>

int find_length(int num) 
{
    if(num == 0) {
        return 0;
    }
    
    return 1 + find_length(num/10);
}

int main() {
    int num = 123456;

    printf("%d", find_length(num));

    return 0;
}