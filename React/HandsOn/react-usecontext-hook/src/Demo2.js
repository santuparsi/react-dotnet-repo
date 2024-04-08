import { createContext, useState, useContext } from "react";
const userContext = createContext(); //create context object
function Component1() {
  const [user, setUser] = useState("Santhosh");
  return (
    <>
      <userContext.Provider value={user}>  {/* set value to the userContext */}
        <h1>Hello, {user}</h1>
        <Component2 />
      </userContext.Provider>
    </>
  );
}
function Component2() {
  return (
    <>
      <h2>Component2</h2>
      <Component3 />
    </>
  );
}
function Component3() {
  return (
    <>
      <h2>Component3</h2>
      <Component4 />
    </>
  );
}
function Component4() {
  return (
    <>
      <h2>Component4</h2>
      <Component5 />
    </>
  );
}
function Component5() {
  const user = useContext(userContext);
  return (
    <>
      <h2>Component5</h2>
      <h2>{`Hello ${user} again!!`}</h2>
    </>
  );
}

export default Component1;
