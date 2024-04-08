// function Sum(a) {
//   let sum = 0;
//   for (let k of a) sum = sum + k;
//   return sum;
// }
// console.log(Sum([12, 23, 34, 45, 56]));
function Sum(...a) {
  let sum = 0;
  for (let k of a) sum = sum + k;
  return sum;
}
console.log(Sum(12, 23, 34, 45, 56));
console.log(Sum(12, 23));
console.log(Sum(12, 23, 34));
