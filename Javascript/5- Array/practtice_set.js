// Multiply each element by 2 and return only those elements which are greater than 10.
let arr = [2,3,4,6,8];
let arr2 = arr.map((currentElement) =>  currentElement*2).filter((currentElement)  => currentElement>10);
console.log(arr2)