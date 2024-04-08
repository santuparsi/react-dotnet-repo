const Product = ({ item }) => {
  return (
    <tr>
      <td>{item.id}</td>
      <td>{item.name}</td>
      <td>{item.price}</td>
    </tr>
  );
};
const Demo2 = () => {
  let items = [
    { id: 1, name: "Mouse", price: 500 },
    { id: 2, name: "Keyboard", price: 1500 },
    { id: 3, name: "Pouch", price: 1500 },
    { id: 4, name: "Pendrive", price: 2500 },
  ];
  return (
    <div className="container">
      <table className="table table-striped">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Price</th>
          </tr>
        </thead>
        <tbody>
          {items.map((product) => (
            <Product item={product} />
          ))}
        </tbody>
      </table>
    </div>
  );
};
export default Demo2;
