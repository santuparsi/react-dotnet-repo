const Product = ({ item }) => {
  return (
    <>
      <tr>
        <td>{item.id}</td>
        <td>{item.name}</td>
        <td>{item.price}</td>
        <td>{item.stock}</td>
      </tr>
    </>
  );
};
const Cart = () => {
  return (
    <div className="container">
      <table className="table table-striped">
        <thead className="bg-primary">
          <th>Id</th>
          <th>Name</th>
          <th>Price</th>
          <th>Stock</th>
        </thead>
        <tbody>
          <Product item={{ id: 1, name: "mouse", price: 300, stock: 10 }} />
          <Product item={{ id: 2, name: "keyboar", price: 300, stock: 10 }} />
          <Product item={{ id: 3, name: "bottle", price: 200, stock: 10 }} />
          <Product item={{ id: 4, name: "bisucte", price: 30, stock: 10 }} />
        </tbody>
      </table>
    </div>
  );
};
export default Cart;
