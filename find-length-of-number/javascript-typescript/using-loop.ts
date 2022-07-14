function findLengthUsingDivisionLoop() {
    let num = 123456;
    let counter = 0;

    while (num > 0) {
        num = (num / 10) | 0;       // Bitwise operator to convert decimal number (float) to whole number (int)
        counter += 1;
    }

    console.log(`Final Length: ${counter}`)
}

findLengthUsingDivisionLoop();