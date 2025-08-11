const button = document.getElementById("generate"),
minInp = document.getElementById("min"),
maxInp = document.getElementById("max"),
paragraph = document.getElementById("paragraph"),
clearBtn = document.getElementById("clearBtn");
let min, max, randNum, clear;


button.onclick = function(){
    if(minInp.value=="" || maxInp.value =="") paragraph.textContent = "Please enter min and max value!";
    else{
         min = Number(minInp.value),
        max = Number(maxInp.value);

        randNum = Math.floor(Math.random() * (max - min + 1)) + min;
        paragraph.innerHTML = "Here's a random number between "+ min + " and " + max + ":<br><b>"+randNum+"</b>";
    }

    clear = document.getElementById("clear").checked;
    if(!clear) ClearInp();
}

clearBtn.onclick = function(){
    paragraph.textContent = null;
}
function ClearInp(){
    minInp.value = null,
    maxInp.value = null;
}