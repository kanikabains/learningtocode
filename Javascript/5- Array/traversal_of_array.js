var myFriends=['chris', 'jack', 'john'];
console.log(myFriends[1]);
console.log(myFriends[0]);
console.log(myFriends[2]);
console.log(myFriends.length);

// FOR IN LOOP
for(let elements in myFriends){
    console.log(elements);   // returns index number..
}

//FOR OF LOOP
for(let elements of myFriends){
    console.log(elements);   // returns array elements..
}

// For each loop
myFriends.forEach(function(element, index, array){
console.log(element + " index: " + index + " array " + array);
});

// for each with fat arrow
myFriends.forEach((element,index,array)=>{
    console.log(element + " index: " + index + " array " + array);
})
