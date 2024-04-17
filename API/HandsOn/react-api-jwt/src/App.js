import logo from "./logo.svg";
import "./App.css";
import Login from "./login";
import Header from "./header";
import ProductView from "./productview";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import AdminDashboard from "./admin-dashboard";
import CustomerDashboard from "./customer-dashboard";
import AddProduct from "./add-product";
function App() {
  return (
    <div className="container">
      <Header />
      <Router>
        <Routes>
          <Route exact path="/" element={<Login />} />
          <Route path="logout" element={<Login />} />

          <Route path="admin-dashboard" element={<AdminDashboard />}>
            <Route path="view" element={<ProductView />} />
            <Route path="add-product" element={<AddProduct />} />
          </Route>
          <Route path="customer-dashboard" element={<CustomerDashboard />}>
            <Route path="view" element={<ProductView />} />
            <Route path="add-product" element={<AddProduct />} />
          </Route>
        </Routes>
      </Router>
    </div>
  );
}

export default App;
