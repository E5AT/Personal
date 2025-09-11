/*const hello = //() => console.log("Hello");
//(name) => console.log(`Hello, I'm ${name}`);
(name, age) => console.log(`Hello, I'm ${name} and I'm ${age} years old`);

hello("Esat", 19);*/

//setTimeout(()=>console.log("Hello"),3000);

const nums = [1,2,3,4,5,6];
const squares = nums.map((element)=>Math.pow(element,2));
const evenNums = nums.filter((element)=>element%2===0);
const total = nums.reduce((accumulator, element)=>accumulator+element);

console.log(total);