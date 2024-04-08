class Car {
  constructor(make, model, price, year) {
    this.make = make;
    this.model = model;
    this.price = price;
    this.year = year;
  }
  details = () => {
    console.log(
      `Make:${this.make} Model:${this.model} Price:${this.price} Year:${this.year}`
    );
  };
}
class Audi extends Car {
  constructor(make, model, price, year, color) {
    //super("Audi", "Audi123", 3450000, 2021); //inovkes Car constructor
    super(make, model, price, year);
    this.color = color;
  }
  details = () => {
    console.log(
      `Make:${this.make} Model:${this.model} Color:${this.color} Price:${this.price} Year:${this.year}`
    );
  };
  f() {
    this.details();
    super.details();
  }
}
let obj = new Audi("Audi", "KKK", 4320987432, 2023, "Black");
obj.details();
