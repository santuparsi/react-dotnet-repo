function GetObject() {
  //retrun object
  return { id: 1, product: "Mouse", price: 200 };
}
function GetCities() {
  //retrun array
  return ["Chennai", "Pune", "Delhi", "Bangalore"];
}
for (let k of GetCities()) {
  console.log(k);
}
function GetStudents() {
  let students = [
    { id: 23, n: "Rohan", age: 12, std: "2" },
    { id: 24, n: "Ram", age: 11, std: "2" },
    { id: 25, n: "Tina", age: 10, std: "1" },
    { id: 26, n: "Merry", age: 13, std: "3" },
    { id: 27, n: "Mic", age: 12, std: "2" },
  ];
  return students;
}
for (let student of GetStudents()) {
  console.log(`Id:${student.id}
      Name:${student.n}
      Age:${student.age}
      Std:${student.std}`);
}
