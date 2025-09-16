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

User.getUserCount();