import React, { Fragment, useRef } from "react";

const Demo1 = () => {
  const focusPoint = useRef("Hello");
  const onclickHandler = () => {
    focusPoint.current.value = "The quick brown fox jumps over the lazy dog";
    focusPoint.current.focus();
  };
  return (
    <Fragment>
      <div>
        <button onClick={onclickHandler}>Action</button>
      </div>
      <label>Click on the action button to focus and populate the text.</label>
      <br />
      <textarea ref={focusPoint} />
    </Fragment>
  );
};
export default Demo1;
