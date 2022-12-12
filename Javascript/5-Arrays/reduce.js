let arr = [5,6,2];
let sum = arr.reduce((accumulator,currentElement,index, array) =>{
return accumulator+=currentElement;
})
console.log(sum);