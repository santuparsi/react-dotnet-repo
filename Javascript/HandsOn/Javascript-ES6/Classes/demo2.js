class Employee {
  //Parameter constructor
  constructor(id, name, desig, jdate, salary) {
    this.id = id;
    this.name = name;
    this.designation = desig;
    this.joinDate = jdate;
    this.salary = salary;
  }
  //method
  Details() {
    console.log(
      `Id:${this.id} Name:${this.name} 
      Designation:${this.designation} 
      JoinDate:${this.joinDate} Salary:${this.salary}`
    );
  }
}
let e1 = new Employee(
  432432,
  "Raj",
  "Programmer",
  new Date(2024, 2, 21),
  23000
);
e1.Details();
let e2 = new Employee(
  90989,
  "Karan",
  "Sr Programmer",
  new Date(2020, 8, 21),
  78000
);
e2.Details();
