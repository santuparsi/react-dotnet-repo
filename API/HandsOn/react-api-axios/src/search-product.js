import React, { useState } from "react";
import axios from "axios";
const SearchProduct = () => {
  const [id, setId] = useState(0);
  const [name, setName] = useState("");
  const [price, setPrice] = useState(0);
  const [stock, setStock] = useState(0);
  const seachHandler = () => {
    let item = { id: id, name: name, price: price, stock: stock };
    console.log(item);
    axios
      .get("http://localhost:5197/api/Product/GetById/" + id)
      .then((response) => {
        console.log(response.data);
        setName(response.data.name);
        setPrice(response.data.price);
        setStock(response.data.stock);
      })
      .catch((error) => console.log(error));
  };
  const editHandler = () => {
    let item = { id: id, name: name, price: price, stock: stock };
    console.log(item);
    axios
      .put("http://localhost:5197/api/Product/Edit", item)
      .then((response) => {
        console.log(response.data);
      })
      .catch((error) => console.log(error));
  };
  const deleteHandler = () => {
    let item = { id: id, name: name, price: price, stock: stock };
    console.log(item);
    axios
      .delete("http://localhost:5197/api/Product/DeleteProduct/" + id)
      .then((response) => {
        console.log(response.data);
      })
      .catch((error) => console.log(error));
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
            <button className="btn btn-primary" onClick={seachHandler}>
              Search
            </button>
            <button className="btn btn-primary" onClick={editHandler}>
              Edit
            </button>
            <button className="btn btn-primary" onClick={deleteHandler}>
              Delete
            </button>
          </td>
        </tr>
      </table>
    </>
  );
};
export default SearchProduct;
