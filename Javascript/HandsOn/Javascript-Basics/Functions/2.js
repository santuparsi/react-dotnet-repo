function Square(n) {
  return n * n;
}
let result = Square(10);
console.log(result);
function Greet(n) {
  return "Hello " + n;
}
function IsEven(n) {
  if (n % 2 == 0) return true;
  else return false;
}
console.log(Greet("Virat"));
console.log(IsEven(11) ? "Even" : "Odd");
