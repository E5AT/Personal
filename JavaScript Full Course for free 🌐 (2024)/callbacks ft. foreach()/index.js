//CALLBACKS

/*hello(wait);

function hello(callback){
    console.log("Hello!");
    callback();
}

function wait(){
    console.log("Wait!");
}

function leave(){
    console.log("Leave!");
}

function goodbye(){
    console.log("Goodbye!");
}*/

/*sum(displayPage, 1,2);

function sum(callback, x,y){
    let result = x+y;
    callback(result);
}

function displayConsole(result){
    console.log(result);
}

function displayPage(result){
    document.getElementById("myH1").textContent = result;
}*/

//FOREACH()

/*let numbers = [1,2,3,4,5];

numbers.forEach(triple);
numbers.forEach(display);

function double(element, index, array){
    array[index] = element*2;
}

function triple(element, index, array){
    array[index] = element*3;
}

function display(element){
    console.log(element);
}*/

let fruits = ["apple", "orange", "banana", "coconut"];

//fruits.forEach(upperCase);
fruits.forEach(capitalize);
fruits.forEach(display);

function upperCase(element, index, array){
    array[index] = element.toUpperCase();
}

function capitalize(element, index, array){
    array[index] = element.charAt(0).toUpperCase()+element.slice(1);
}

function display(element){
    console.log(element);
}