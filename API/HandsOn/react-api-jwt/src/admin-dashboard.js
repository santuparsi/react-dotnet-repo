import React from "react";
import { Link, Outlet } from "react-router-dom";
export default function AdminDashboard() {
  return (
    <div>
      <table>
        <tr>
          <td>
            <Link to="view">Products</Link>
          </td>
          <td>
            <Link to="add-product">Add-Product</Link>
          </td>
          <td>
            <Link to="/logout">LogOut</Link>
          </td>
        </tr>
      </table>
      <Outlet />
    </div>
  );
}
