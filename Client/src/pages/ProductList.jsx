import React, { useEffect, useState } from 'react';
import api from '../api';

export default function ProductList() {
  const [products, setProducts] = useState([]);
  const [q, setQ] = useState('');
  const [page, setPage] = useState(1);
  const [total, setTotal] = useState(0);

  async function load() {
    const res = await api.get('/products', { params: { q, page, pageSize: 10 } });
    setProducts(res.data.data);
    setTotal(res.data.total);
  }

  useEffect(()=>{ load(); }, [q, page]);

  return (
    <div>
      <div className="flex gap-2 mb-4">
        <input value={q} onChange={(e)=>setQ(e.target.value)} placeholder="Search..." className="p-2 border flex-1" />
        <button onClick={()=>setPage(1)} className="bg-azureAccent text-white px-4 rounded">Search</button>
      </div>
      <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
        {products.map(p => (
          <div key={p.id} className="card">
            <img src={p.imageUrl} alt={p.name} className="w-full h-40 object-cover mb-3" />
            <h3 className="font-bold">{p.name}</h3>
            <p className="text-sm">{p.description}</p>
            <div className="mt-2 font-semibold">${p.price}</div>
          </div>
        ))}
      </div>
    </div>
  );
}
