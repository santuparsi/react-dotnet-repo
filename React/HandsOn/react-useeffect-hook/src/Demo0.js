import { React, useState, useEffect } from "react";
const Demo0 = () => {
  //state
  const [count, setCount] = useState(0);
  useEffect(() => {
    setCount(count + 1);
  });
  return <div>I have rendered {count} times!!</div>;
};
export default Demo0;
