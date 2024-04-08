//if-else-if
let m1 = 23,
  m2 = 90,
  m3 = 89,
  m4 = 78,
  m5 = 77;
let total = m1 + m2 + m3 + m4 + m5;
let avg = total / 5;
let result = "";
if (m1 > 40 && m2 > 40 && m3 > 40 && m4 > 40 && m5 > 40) {
  if (avg >= 70) result = "Distinction";
  else if (avg >= 60) result = "FirstClass";
  else if (avg >= 50) result = "SecondClass";
  else result = "ThirdClass";
} else result = "Fail";
if (result != "Fail") {
  console.log(`Total Marks:${total} Percentage:${avg}%`);
} else console.log("Result:Fail");
