import { useState, useEffect } from "react";
import axios from "axios";
function ProductView() {
  const [items, setItems] = useState([]);
  useEffect(() => {
    console.log(localStorage.getItem("token"));
    axios
      .get("http://localhost:5263/api/Product/GetAll", {
        headers: {
          Authorization: `Bearer ${localStorage.getItem("token")}`,
        },
      })
      .then((response) => {
        setItems(response.data);
        console.log(response.data);
      });
  }, []);
  return (
    <>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Price</th>
            <th>Stock</th>
          </tr>
        </thead>
        <tbody>
          {items.map((item) => (
            <tr>
              <td>{item.id}</td>
              <td>{item.name}</td>
              <td>{item.price}</td>
              <td>{item.stock}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
export default ProductView;
