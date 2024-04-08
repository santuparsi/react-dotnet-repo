//nested-if
let a = 10,
  b = 20,
  c = 30;
if (a > b) {
  if (a > c) console.log(`${a} Max`);
  else console.log(`${c} is Max`);
} else {
  if (b > c) console.log(`${b} Max`);
  else console.log(`${c} is Max`);
}
