function Message() {
  let n = "Sandeep";
  let a = 10,
    b = 30;
  let result = false;
  return (
    <>
      <h1>React is a Javascript Lib</h1>
      <p>Components are two types</p>
      <h3>Hello,{n}</h3>
      <h4>Addition={a + b}</h4>

      {result ? <h3>GoodMorning</h3> : <h3>GoodNight</h3>}
    </>
  );
}
export default Message;
