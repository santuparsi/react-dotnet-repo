const Greet = (props) => {
  return (
    <>
      <h1>
        Hello,{props.name} You are a 
        {props.profession}
      </h1>
    </>
  );
};
export default Greet;
