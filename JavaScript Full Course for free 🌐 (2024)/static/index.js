/*
STATIC

class User{
    static userCount = 0;

    constructor(username){
        this.username = username;
        User.userCount++;
    }

    static getUserCount(){
        console.log(`There are ${User.userCount} users`);
    }
}

const user1 = new User("Spongebob"),
user2 = new User("Patrick");

User.getUserCount();*/

//INHERITANCE

/*class Animal{
    alive = true;

    eat(){
        console.log(`This ${this.name} is`+(!this.alive?"n't":"")+" eating!");
    }
}

class Rabbit extends Animal{
    name = "Rabbit";
    canJump(){
        console.log(`Yes, ${this.name}s can jump!`);
    }
}

const rabbit = new Rabbit();
rabbit.alive = false;
rabbit.eat();
rabbit.canJump();*/

//SUPER KEYWORD

class Animal{
    constructor(name, age){
        this.name = name;
        this.age = age;
    }
}
class Fish extends Animal{
    constructor(name, age){
        super(name, age);

        console.log(`New animal created named ${this.name} and ${this.age} years old! `)
    }
}

const fish = new Fish("Enes",15);