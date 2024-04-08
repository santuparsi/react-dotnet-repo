//function call-backs
function f1(callback) {
  return callback();
}
function callback() {
  return "I am calling from function!!";
}
f1(callback);
f1(() => "Hey I am calling!!");
