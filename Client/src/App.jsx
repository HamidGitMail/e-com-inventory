import React from 'react';
import { Routes, Route, Link } from 'react-router-dom';
import ProductList from './pages/ProductList';
import Login from './pages/Login';
import ProtectedRoute from './components/ProtectedRoute';

export default function App() {
  return (
    <div>
      <header className="header">
        <div className="container mx-auto flex justify-between">
          <h1 className="text-xl font-bold">e-com-inventory</h1>
          <nav>
            <Link to="/" className="mr-4">Products</Link>
            <Link to="/login">Login</Link>
          </nav>
        </div>
      </header>
      <main className="container mx-auto p-4">
        <Routes>
          <Route path="/" element={<ProductList />} />
          <Route path="/login" element={<Login />} />
          <Route path="/admin" element={<ProtectedRoute><div>Admin area</div></ProtectedRoute>} />
        </Routes>
      </main>
    </div>
  );
}
