import React, { useEffect, useState } from "react";
import logo from "./logo.svg";
import "./App.css";

const API_BASE_URL = "https://localhost:5001";

type Product = {
  name: string;
  price: number;
};

async function getAllProducts(): Promise<Product[]> {
  const result = await fetch(`${API_BASE_URL}/api/Product`);
  return result.json();
}

function App() {
  const [productList, setProductList] = useState<Product[]>([]);

  useEffect(() => {
    getAllProducts().then(setProductList);
  }, []);

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <ul>
          {productList.map((product, index) => (
            <li key={index}>
              {product.name} costs ${product.price}
            </li>
          ))}
        </ul>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
