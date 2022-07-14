function findLengthUsingMultiplicationLoop() {
    let num = 123456;
    let counter = 0;
    let temp = 1;

    while (temp <= num) {
        temp *= 10;
        counter++;
    }

    console.log(`Final Length: ${counter}`)
}

findLengthUsingMultiplicationLoop();