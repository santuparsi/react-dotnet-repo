import React, { useState, useEffect } from "react";
const Demo2 = () => {
  //state
  const [count, setCount] = useState(0);
  useEffect(() => {
    setTimeout(() => {
      setCount((prvcount) => prvcount + 1);
    }, 1000);
  });
  return <div>I have rendered {count} times!!</div>;
};
export default Demo2;
