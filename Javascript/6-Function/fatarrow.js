const sum = () => {
    let a = 5, b = 5;
    let sum = a+b;
    return(`sum is ${sum}`);
}
console.log(sum());

// we can also write as
const sum1 = () => `here sum is ${a=5,b=6}`;
console.log(sum1());
