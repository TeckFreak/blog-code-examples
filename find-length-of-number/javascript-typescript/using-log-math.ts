function findLengthUsingLog() {
    const num = 123456;
    const logValue = Math.log10(num);
    const finalLength = Math.floor(logValue) + 1;

    console.log(`Final Length: ${finalLength}`);

}

findLengthUsingLog();