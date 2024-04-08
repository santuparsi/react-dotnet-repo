let obj = { id: 23, n: "Rohan", age: 12, std: "2" };
//list data
let students = [
  { id: 23, n: "Rohan", age: 12, std: "2" },
  { id: 24, n: "Ram", age: 11, std: "2" },
  { id: 25, n: "Tina", age: 10, std: "1" },
  { id: 26, n: "Merry", age: 13, std: "3" },
  { id: 27, n: "Mic", age: 12, std: "2" },
];
console.log(students[0]);
for (let student of students) {
  console.log(`Id:${student.id}
    Name:${student.n}
    Age:${student.age}
    Std:${student.std}`);
}
