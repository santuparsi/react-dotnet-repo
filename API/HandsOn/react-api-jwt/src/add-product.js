import React, { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
const AddProduct = () => {
  const navigate = useNavigate();
  const [id, setId] = useState(0);
  const [name, setName] = useState("");
  const [price, setPrice] = useState(0);
  const [stock, setStock] = useState(0);
  const saveHandler = () => {
    console.log(localStorage.getItem("token"));
    let item = { id: id, name: name, price: price, stock: stock };
    console.log(item);
    axios
      .post("http://localhost:5263/api/Product/AddProduct", item, {
        headers: {
          Authorization: `Bearer ${localStorage.getItem("token")}`,
        },
      })
      .then((response) => {
        console.log(response.data);
      })
      .catch((error) => {
        console.log(error);
        console.log(error.message);
        if (error.response.statusText === "Forbidden") {
          navigate("/logout");
        }
      });
  };
  return (
    <>
      <table>
        <tr>
          <td>Id</td>
          <td>
            <input
              type="number"
              value={id}
              onChange={(e) => setId(e.target.value)}
            />
          </td>
        </tr>
        <tr>
          <td>Name</td>
          <td>
            <input
              type="text"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
          </td>
        </tr>
        <tr>
          <td>Price</td>
          <td>
            <input
              type="number"
              value={price}
              onChange={(e) => setPrice(e.target.value)}
            />
          </td>
        </tr>
        <tr>
          <td>Stock</td>
          <td>
            <input
              type="number"
              value={stock}
              onChange={(e) => setStock(e.target.value)}
            />
          </td>
        </tr>
        <tr>
          <td colSpan={2}>
            <button className="btn btn-primary" onClick={saveHandler}>
              Add
            </button>
          </td>
        </tr>
      </table>
    </>
  );
};
export default AddProduct;
