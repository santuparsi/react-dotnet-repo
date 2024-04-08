//class is a collection of varaibles,methods and so on
class student {
  constructor() {
    //variable declation here
    this.id = 324342;
    this.name = "Suren";
    this.age = 11;
    this.std = 4;
  }
}
//initiate object
const obj = new student();
console.log(`Id:${obj.id} Name:${obj.name} Age:${obj.age} Std:${obj.std}`);
const s1=new student();
s1.id=78987;
s1.name='Tina';
s1.age=10;
s1.std=3;
console.log(`Id:${s1.id} Name:${s1.name} Age:${s1.age} Std:${s1.std}`);
