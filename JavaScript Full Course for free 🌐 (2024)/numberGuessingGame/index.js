const button = document.getElementById("start");
let num, guess, text , guessed;
const trophies = document.getElementById("trophies");

button.onclick = function(){
    text = "Your guess:";
    num = Math.floor(Math.random() * 101);
    do{
        guess = window.prompt(text);
        if(guess=="" || guess == null) text = "Please enter a number!:";
        else{
            guess = Number(guess);
            text = Hint();
        }
    }while(!Check(num, guess))
        alert(`Congratulations, you won! Number was: ${num}. Here's your trophy: 🏆`);
        trophies.textContent += "🏆";
}
function Check(){
    return num == guess;
}
function Hint(){
    if(num>guess) return "Up!:";
    return "Down!:";
}