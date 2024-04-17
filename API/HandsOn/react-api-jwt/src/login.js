import React, { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
function Login() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const navigate = useNavigate();
  //const [login, setLogin] = useState({});

  const Validate = () => {
    let login = { email: email, password: password };
    console.log(login);
    axios
      .post("http://localhost:5263/api/User/Validate", login)
      .then((response) => {
        console.log(response.data);
        let token = response.data.token;
        if (token !== null) {
          localStorage.setItem("token", token);
          let role = response.data.role;
          if (role === "Admin") {
            // redirect to admin dash-board
            navigate("/admin-dashboard");
          } else if (role === "Customer") {
            //redirect to customer dash-board
            navigate("/customer-dashboard");
          }
        } else {
          setError("Invalid Credentials");
        }
      });
  };
  return (
    <div className="container">
      <form>
        <div className="form-group row">
          <label htmlFor="inputEmail" className="col-sm-2 col-form-label">
            Username
          </label>
          <div className="col-md-4">
            <input
              type="text"
              className="form-control"
              id="staticEmail"
              placeholder="santo"
              onChange={(e) => setEmail(e.target.value)}
            />
          </div>
        </div>
        <div className="form-group row">
          <label htmlFor="inputPassword" className="col-sm-2 col-form-label">
            Password
          </label>
          <div className="col-md-4">
            <input
              type="password"
              className="form-control"
              id="inputPassword"
              placeholder="Password"
              onChange={(e) => setPassword(e.target.value)}
            />
          </div>
        </div>
        <div className="form-group">
          <label className="text-warning">{error}</label>
        </div>
        <button type="button" className="btn btn-primary" onClick={Validate}>
          Sign in
        </button>
      </form>
    </div>
  );
}
export default Login;
