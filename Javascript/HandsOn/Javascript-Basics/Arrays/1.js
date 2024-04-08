//array declaration
let nos = [12, 23, 34, 45, 45, 56];
console.log(nos[2]); //34
//access all values
for (let k = 0; k < nos.length; k++) {
  console.log(nos[k]);
}
//for-of
for (let n of nos) {
  console.log(n);
}
