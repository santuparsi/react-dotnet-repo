import { React, useState, useEffect } from "react";
const Demo1 = () => {
  //state
  const [count, setCount] = useState(0);
  useEffect(() => {
    setCount(count+1);
  }, []); //adding empty array calls useEffect only once.
  return <div>I have rendered {count} times!!</div>;
};
export default Demo1;
