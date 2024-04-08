let n = [23, 34, 45, 65, 56];
let k = n.find((n) => n > 50);
console.log(k);
let r = n.filter((n) => n > 50);
console.log(r);
let students = [
  { id: 23, n: "Rohan", age: 12, std: "2" },
  { id: 24, n: "Ram", age: 11, std: "2" },
  { id: 25, n: "Tina", age: 10, std: "1" },
  { id: 26, n: "Merry", age: 13, std: "3" },
  { id: 27, n: "Mic", age: 12, std: "2" },
];
//return student with id=24
let obj = students.find((n) => n.id == 24);
console.log(obj);
let items = students.filter((item) => item.std == 2);
console.log(items);
