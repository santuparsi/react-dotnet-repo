let n = [23, 34, 45, 45, 56];
//return sqaure of array no's
n.forEach((n) => console.log(n * n));
let result = n.map((n) => n * n);
console.log(result);
let flowers = ["rose", "lilly", "tulips"];
let result1 = flowers.map((n) => {
  return n[0].toUpperCase() + n.slice(1, n.length);
});
console.log(result1);
