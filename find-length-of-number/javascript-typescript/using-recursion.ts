function findLength(n: number): number {
    if (n == 0) {
        return 0;
    }

    return 1 + findLength((n / 10) | 0);        // Bitwise operator to convert decimal number (float) to whole number (int)
}

function findLengthUsingRecursion() {
    let num = 123456;
    console.log(`Final Length: ${findLength(num)}`)
}

findLengthUsingRecursion();