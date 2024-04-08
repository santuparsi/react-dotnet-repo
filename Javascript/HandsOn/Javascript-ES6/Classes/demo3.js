class product {
  constructor(id, name, price, stock) {
    this.id = id;
    this.name = name;
    this.price = price;
    this.stock = stock;
  }
  details = () => {
    console.log(
      `id:${this.id} name:${this.name} price:${this.price} stock:${this.stock}`
    );
  };
}
let products = [
  new product(1, "Mouse", 1000, 10),
  new product(2, "Keyboard", 1000, 10),
  new product(3, "Pendrive", 800, 10),
  new product(4, "Speaker", 11000, 10),
];
for (let obj of products) {
  obj.details();
}
