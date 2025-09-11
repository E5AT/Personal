class Product{
    constructor(name, price){
        this.name = name,
        this.price = price;
    }

    displayProduct(){
        console.log(`Product: ${this.name}`);
        console.log(`Price: $${this.price}`);
    }
}

const product = new Product("Pretzel Sticks", 0.99);

product.displayProduct();