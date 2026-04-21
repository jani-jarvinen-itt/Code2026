import { useEffect, useState } from 'react'

const cellStyle = {
  border: "1px solid #ddd",
  padding: "10px",
};

function ProductTableFetch() {

    console.log("ProductTableFetch function called");
    const [products, setProducts] = useState<any[]>([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        console.log("ProductTableFetch useEffect called");
        fetch("https://dummyjson.com/products")
            .then((res) => res.json())
            .then((data: any) => {
                console.log("Products fetched:", data);
                setProducts(data.products);
                setLoading(false);
            })
            .catch(() => setLoading(false));
    }, []);

    if (loading) {
        return <h1>Loading products...</h1>;
    }

    console.log("ProductTableFetch renders HTML table");
    return <div>
        <h1>Product Table Fetch</h1>
        <div style={{ padding: "20px" }}>
            <table
                style={{
                    width: "100%",
                    borderCollapse: "collapse",
                    border: "1px solid #ddd",
                }}
            >
                <thead>
                    <tr>
                        <th>Product Title</th>
                        <th>Product Price</th>
                    </tr>
                </thead>
                <tbody>
                    {products.map((product) => (
                        <tr key={product.id}>
                            <td style={cellStyle}>{product.title}</td>
                            <td style={cellStyle}>${product.price.toFixed(2)}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    </div>;
}

export default ProductTableFetch;
