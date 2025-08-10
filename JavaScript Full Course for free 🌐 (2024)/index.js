//console.log(`Hello World!`);
//console.log(`I like pizza!`);

//window.alert(`This is an alert!`);
//window.alert(`I like pizza!`);

//document.getElementById("myH1").textContent = "Hello";
//document.getElementById("myP").textContent = "I like pizza!";

// This is a comment

/*
    This
    is
    a
    comment
*/

//variables
/*let age = 18, firstName = "Esat", online = false;
document.getElementById("myH1").textContent = `Hi ${firstName},`;
document.getElementById("myP1").textContent = `You're ${age} years old`;
document.getElementById("myP2").textContent = `And you're ${online?"online":"offline"}`;*/

//user input

//easy method: 
let username;
/*username = window.prompt("Ur username: ");
console.log(username);*/

//the hard one:

/*document.getElementById("mySubmit").onclick = function(){
    username = document.getElementById("myText").value;
    document.getElementById("myH1").textContent = `Welcome, ${username}!`;

}*/

//type conversion

let age = Number(window.prompt("Whats your age?"));

age++;

document.getElementById("myH1").textContent = `Youll be ${age} years old after 1 year!`;