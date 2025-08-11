const
americano = document.getElementById("americano"),
latte = document.getElementById("latte"),
espresso = document.getElementById("espresso"),
small = document.getElementById("small"),
medium = document.getElementById("medium"),
large = document.getElementById("large"),
order = document.getElementById("order"),
paragraph = document.getElementById("paragraph");
let size, coffee, description, price;

order.onclick = function(){
    size = small.checked?"Small":medium.checked?"Medium":large.checked?"Large":null;
    coffee = americano.checked?"Americano":latte.checked?"Latte":espresso.checked?"Espresso":null;
    if(size==null&&coffee==null) paragraph.textContent = "Please select coffee kind and size!";
    else if(size==null) paragraph.textContent = "Please select coffee size!";
    else if(coffee==null) paragraph.textContent = "Please select coffee kind!";
    else{
        switch(size){
            case "Small": price = 2.50; break;
            case "Medium": price = 3.50; break;
            case "Large": price = 4.50; break;
        }
        
        switch(coffee){
            case "Americano": description = "Smooth and bold black coffee."; break;
            case "Latte": description = "Creamy milk coffee for a gentle taste."; break;
            case "Espresso": description = "Strong and rich concentrated coffee shot."; break;
        }

        paragraph.textContent = `${size} ${coffee} - ${description} Price: $${price.toFixed(2)}`;
    }
}