import logo from "./logo.svg";
import "./App.css";
import Message from "./Message";
import Greet from "./Greet";
import Garage from "./Car";
import Cart from "./Product";
function App() {
  return (
    <div className="App">
      {/* <Greet name="Virat" 
      profession="Cricketer" />
      <Greet name="Rohith" 
      profession="Teacher" /> */}
      {/* <Garage make="Maruti" model="Breeza" color="Red" /> */}
      <Cart />
    </div>
  );
}

export default App;
