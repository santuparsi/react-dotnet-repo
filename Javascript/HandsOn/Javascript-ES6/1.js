function Greet(n) {
  return "Hello " + n;
}
function Add(a, b) {
  return a + b;
}
function SumArray(a) {
  let sum = 0;
  for (let k of a) sum = sum + k;
  return sum;
}
//Arrow functions
//const fn=(params)=>expression
const Message = (n) => "Hello " + n;
console.log(Message("Virat"));
const Sum = (a, b) => a + b;
console.log(Sum(2, 3));
const Sum1 = (a) => {
  let sum = 0;
  for (let k of a) sum = sum + k;
  return sum;
};
console.log(Sum1([23,34,45,56]));