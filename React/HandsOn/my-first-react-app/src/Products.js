import React, { useEffect, useState } from "react";
import axios from "axios";

export default function Products() {
  const [items, setItms] = useState([]);
  useEffect(() => {
    axios
      .get("http://localhost:5161/api/Product/GetAll")
      .then((response) => {
        console.log(response.data);
        setItms(response.data);
      })
      .catch((error) => console.log(error));
  }, []);
  return <div>Products</div>;
}
