num = 0;
const down = document.getElementById("down");
const reset = document.getElementById("reset");
const up = document.getElementById("up");

function UpdateText(){
    document.getElementById("num").textContent = num;
}

down.onclick = function(){
    num--;
    UpdateText();
}

reset.onclick = function(){
    num = 0;
    UpdateText();
}

up.onclick = function(){
    num++;
    UpdateText();
}