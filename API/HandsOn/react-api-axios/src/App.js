import logo from "./logo.svg";
import "./App.css";
import GetAll from "./get-all";
import AddProduct from "./add-product";
import SearchProduct from "./search-product";

function App() {
  return (
    <div className="App">
      <AddProduct />
      <GetAll />
      <SearchProduct />
    </div>
  );
}

export default App;
