//functions
function Message() {
  console.log("Welcome to Javascript Functions");
}
//call functions
Message();
function Greet(n) {
  console.log("Hello " + n);
}
Greet("Virat");
Greet("Rahul");
Greet();
function Add(a, b = 9) {
  //default parameter to b
  let c; //local variable
  c = a + b;
  console.log(`Addition:${c}`);
}
Add(3, 4);
Add(4);
