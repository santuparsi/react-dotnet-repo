const Movie = ({ movie }) => {
  return (
    <>
      <td>{movie.name}</td>
      <td>{movie.lang}</td>
      <td>{movie.actor}</td>
      <td>{movie.director}</td>
      <td>{movie.year}</td>
    </>
  );
};
const MovieList = () => {
  let list = [
    {
      id: 1,
      name: "RRR",
      lang: "Telugu",
      actor: "Charan",
      director: "Rajamouli",
      year: 2021,
    },
    {
      id: 2,
      name: "Javan",
      lang: "Hindi",
      actor: "Sharuk",
      director: "Atli",
      year: 2023,
    },
    {
      id: 3,
      name: "Hanuman",
      lang: "Telugu",
      actor: "Teja",
      director: "Prashanth",
      year: 2023,
    },
    {
      id: 4,
      name: "Animal",
      lang: "Hindi",
      actor: "Ranveer",
      director: "Sandeep",
      year: 2021,
    },
  ];
  return (
    <table className="table table-striped">
      <thead className="table-info">
        <th>Name</th>
        <th>Lang</th>
        <th>Actor</th>
        <th>Director</th>
        <th>Year</th>
      </thead>
      <tbody>
        {list.map((m) => (
          <tr key={m.id}>
            <Movie movie={m} />
          </tr>
        ))}
      </tbody>
    </table>
  );
};
export default MovieList;
