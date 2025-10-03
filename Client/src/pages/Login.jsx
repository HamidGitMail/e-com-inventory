import React, { useState } from 'react';
import api, { setToken } from '../api';
import { useNavigate } from 'react-router-dom';

export default function Login() {
  const [username, setUsername] = useState('admin');
  const [password, setPassword] = useState('Admin@123');
  const [error, setError] = useState('');
  const nav = useNavigate();

  async function submit(e) {
    e.preventDefault();
    try {
      const res = await api.post('/auth/login', { username, password });
      setToken(res.data.token);
      localStorage.setItem('token', res.data.token);
      nav('/');
    } catch (err) {
      setError('Login failed');
    }
  }

  return (
    <div className="max-w-md mx-auto card">
      <h2 className="text-lg mb-4">Login</h2>
      <form onSubmit={submit} className="space-y-3">
        <input value={username} onChange={(e)=>setUsername(e.target.value)} className="w-full p-2 border" />
        <input value={password} onChange={(e)=>setPassword(e.target.value)} type="password" className="w-full p-2 border" />
        <button className="bg-azureAccent text-white px-4 py-2 rounded">Login</button>
      </form>
      {error && <div className="text-red-600 mt-2">{error}</div>}
    </div>
  );
}
