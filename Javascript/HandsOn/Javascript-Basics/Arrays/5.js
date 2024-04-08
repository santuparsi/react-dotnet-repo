let n = [23, 34, 45];
//add value to the array
n.push(67);
n.unshift(12); //add items at begining
console.log(n);
//remove value from the array
n.pop();
n.shift();
console.log(n);
let n1 = [23, 34, 45, 95, 56, 67];
let n2 = n1.splice(1, 2);
console.log(n1);
console.log(n2);
let n3 = [23, 34, 45, 95, 56, 67];
let n4 = n3.slice(2, 5);
console.log(n3);
console.log(n4);
