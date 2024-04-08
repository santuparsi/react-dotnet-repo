const Demo1 = () => {
  let cities = ["Pune", "Chennai", "Delhi", "Mumbai"];
  return (
    <>
      <table>
        <tr>
          <th>City</th>
        </tr>
        {cities.map((city) => (
          <tr>
            <td>{city}</td>
          </tr>
        ))}
      </table>
      <hr />
      Select City:
      <select>
        <option>Pune</option>
        <option>Chennai</option>
        <option>Hyderabad</option>
      </select>
      Select City:
      <select>
        <option>select city</option>
        {cities.map((c) => (
          <option>{c}</option>
        ))}
      </select>
    </>
  );
};
export default Demo1;
