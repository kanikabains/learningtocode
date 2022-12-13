const arr = [1,4,9,16,25];
let newArr = arr.map((currentElement,index,array) => {
return currentElement>9;
})
console.log(arr);
console.log(newArr);