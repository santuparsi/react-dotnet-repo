import React, { Component } from "react";
class Employee extends Component {
  constructor() {
    super();
    this.state = {
      id: 3490,
      name: "Rohan",
      salary: 45000,
      designation: "programmer",
    };
  }
  updateEmployee = () => {
    this.setState({
      salary: 56000,
    });
  };
  render() {
    return (
      <>
        <h1>Id:{this.state.id}</h1>
        <h1>Name:{this.state.name}</h1>
        <h1>Salary:{this.state.salary}</h1>
        <h1>Designation:{this.state.designation}</h1>
        <button onClick={this.updateEmployee}>Update</button>
      </>
    );
  }
}
export default Employee;
