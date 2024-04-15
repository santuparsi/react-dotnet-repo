import React, { useEffect, useState } from "react";
import axios from "axios";
const GetAll = () => {
  const [products, setProducts] = useState([]);
  useEffect(() => {
    axios
      .get("http://localhost:5197/api/Product/GetAll")
      .then((response) => {
        console.log(response.data); //response.data retruns json data
        setProducts(response.data);
      })
      .catch((error) => console.log(error));
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
          {products.map((p) => (
            <tr key={p.id}>
              <td>{p.id}</td>
              <td>{p.name}</td>
              <td>{p.price}</td>
              <td>{p.stock}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
};
export default GetAll;
