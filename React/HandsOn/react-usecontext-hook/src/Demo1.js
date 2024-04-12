import React, { useContext, createContext } from "react";
//create a context with a default value
const MyContext = createContext("U0001");
const ChildComponent = () => {
  //consume the context value using useContext
  const contextValue = useContext(MyContext);
  return <p>{contextValue}</p>;
};
const ParentComponent = () => {
  return (
    //update context data
    <MyContext.Provider value="U0002">
      <ChildComponent />
    </MyContext.Provider>
  );
};
export default ParentComponent;
