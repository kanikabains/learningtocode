// push()
const animals = ['pigs', 'goats', 'sheeps'];
const count = animals.push('chicken', 'cats', 'cow');
console.log(animals);
console.log(count);

// unshift() ->  add elements in starting of array
const fruits = ["Apple","Banana", "Grapes"];
const count1 = fruits.unshift("orange")
console.log(fruits);

// pop() -> remove last element from array
const vegetables = ["broccoli", "carrot", "peas"];
console.log(vegetables.pop());

// shift-> remove first element of array
const car = ["BMW", "Audi","Tesla"];
console.log(car.shift());
console.log(car);


// splice()
const months = ['jan', 'feb', 'march'];
const newMonths = months.splice(months.length,0,"Dec");
console.log(months);

// update feb with july
const indexOfMonth = months.indexOf('feb');
if(indexOfMonth!=-1){
    const updateMonth = months.splice(indexOfMonth,1,"July");
    console.log(months);
}else{
    console.log("No such data found");
}

// Delete July from array

const indexOfMonth1 = months.indexOf('jan');
if(indexOfMonth1!=-1){
    const updateMonth = months.splice(indexOfMonth1,4);
    console.log(months);
}else{
    console.log("No such data found");
}