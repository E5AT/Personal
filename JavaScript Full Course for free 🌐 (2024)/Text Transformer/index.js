const button = document.getElementById("start");
let stop=false, result, liked;

button.onclick = function(){
    do{
        result = window.prompt("Please enter text:");
        console.log(result);
        result = result.trim().toUpperCase().replaceAll(" ", "_").slice(0, 10);
        alert(result);
        liked = window.prompt("You liked it? Y/n:");
        liked = liked==null||liked==""||liked=="y"||liked=="Y"?true:false;
        if(liked) stop = true;
        else stop=false;
    }while(!stop)
}