/*const person ={
    name: "Esat",
    age: 18,
    sayHello: function(){console.log(`${this.name} says 'Hello'!`)}, // here I used this keyword
    sayAge:()=>console.log(`I am ${person.age} years old!`) //this keywords doesnt work with arrow functions
}

person.sayAge();*/

function Car(brand, model, year, color){
    this.brand = brand,
    this.model = model,
    this.year = year,
    this.color = color,
    this.drive = function(){
        console.log(`You are driving a ${color} ${year} ${brand} ${model}. And it looks kinda cool :>!`);
    }
}

const car = new Car("Honda", "Civic", 1997,"red");

car.drive();