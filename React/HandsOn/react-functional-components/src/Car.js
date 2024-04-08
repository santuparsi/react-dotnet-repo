import "./App.css";
const Car = ({ make, model, color }) => {
  return (
    <>
      <h2 style={{ color: "red" }}>Make:{make}</h2>
      <h2 style={{ color: "blue", fontSize: "20px" }}>
        Model:{model} Color:{color}
      </h2>
    </>
  );
};
const Garage = (props) => {
  let obj = { make: "Audi", model: "Hect", color: "black" };
  return (
    <div className="App">
      <Car make="Hundai" model="I10" color="Red" />
      <Car make={obj.make} model={obj.model} color={obj.color} />
      <Car make={props.make} model={props.model} color={props.color} />
    </div>
  );
};
export default Garage;
