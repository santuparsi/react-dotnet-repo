import React from "react";
class Count extends React.Component {
  constructor() {
    super();
    this.state = {
      count: 0,
    };
  }
  SetCount = () => {
    this.setState({
      count: this.state.count + 1,
    });
  };
  render() {
    return (
      <>
        <h1>Count:{this.state.count}</h1>
        <button onClick={this.SetCount}>ClickMe</button>
      </>
    );
  }
}
export default Count;
