// Multiply each element by 2 and return only those elements which are greater than 10.
let arr = [2,3,4,6,8];
let arr2 = arr.map((currentElement) => {
return currentElement*2;
}).filter((currentElement)  =>{
    return currentElement>10
})
console.log(arr2)