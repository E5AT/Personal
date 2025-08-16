const input = document.getElementById("input"),
dicesPrint = document.getElementById("dices");
let numOfDices;

function roll(){
    dicesPrint.innerHTML = "";
    numOfDices = Number(input.value);
    for(let i=0;i<numOfDices;i++){
        dicesPrint.innerHTML += `<img src="images/${Math.floor(Math.random()*6)+1}.png">`;
    }
}