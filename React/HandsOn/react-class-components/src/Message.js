import React from "react";
class Message extends React.Component {
  constructor(props) {
    super(props);
  }
  render() {
    return (
      <>
        <h1>Hello,{this.props.name}</h1>
        <h1>This is Class Component</h1>
      </>
    );
  }
}
export default Message;
