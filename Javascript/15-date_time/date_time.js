// 4 ways to create date objects
//new Date()
//new Date(year, month, day, hours, minutes, seconds, milliseconds)
//new Date(milliseconds)
// new  Date(date string)

let currDate = new Date();
console.log(currDate);

console.log(new Date().toLocaleString()); // return local time
console.log(new Date().toString()); // return GMT Timing
console.log(Date.now()); // returns millisecond from 1st jan 1970
// create Date and Time
var d = new Date(2022,11,12,16,04,30,0);
console.log(d.toLocaleString());

// ALSO
var d = new Date("Dec 12,2022 16:07:00");
console.log(d.toLocaleString());

// get individual date
console.log(currDate.toLocaleString());
console.log(currDate.getFullYear());
console.log(currDate.getDay());
console.log(currDate.getMonth());
console.log(currDate.getDate());

// set individual time
let curTime = new Date();
console.log(curTime.setHours(5));
console.log(curTime.setMinutes(5));
console.log(curTime.setSeconds(5));
console.log(curTime.setMilliseconds(5));
