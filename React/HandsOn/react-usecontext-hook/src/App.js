import React from "react";
import "./App.css";
import { Context } from "./context";
import MyComponent from "./Demo4";
import Application from "./Demo3";
import Component1 from "./Demo0";
import ParentComponent from "./Demo1";
import ChildComponent from "./Demo1";
function App() {
  const value = "My Context Value";
  return (
    // <Context.Provider value={value}>
    //   <MyComponent />
    // </Context.Provider>
    // <Application />
    <ChildComponent />
    // <Component1 />
    // <ParentComponent />
  );
}

export default App;
