const toFahrenheit = document.getElementById("toFahrenheit"),
toCelsius = document.getElementById("toCelsius"),
printResult = document.getElementById("result");
let input, result;

function conversion(){
    input = Number(document.getElementById("input").value);
    if(toFahrenheit.checked){
        result = 9/5*input+32;
        printResult.textContent = result.toFixed(1)+" °F";
    }
    else if(toCelsius.checked){
        result = 5/9*(input-32);
        printResult.textContent = result.toFixed(1)+" °C";
    }
    else{
        printResult.textContent = "Please enter whats required!";
    }
}