var str = "apple, banana,mango";
let res = str.slice(7);
console.log(res);

// Extracting String Character
let str1 = "HELLO WORLD";
console.log(str1.charAt(0));


// charCodeAt()
let stt = "Hello";
console.log(stt.charCodeAt(0));

// return uicode of last character in a string
let message = 'HELLO WORLD';
let lastChar = message.length-1;
console.log(message.charCodeAt(lastChar));

//Property Access
let str2 = "Hello";
console.log(str2[0]);

//toUpperCase
let myName = "Chris";
console.log(myName.toUpperCase());
console.log(myName.toLowerCase());

// string to array
var txt = 'a,b,c,d,e'
console.log(txt.split(","));