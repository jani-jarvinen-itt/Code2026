import { useEffect, useState } from 'react'

const cellStyle = {
  border: "1px solid #ddd",
  padding: "10px",
};

function ProductTableFetchWithFiltering() {

    console.log("ProductTableFetch function called");
    const [products, setProducts] = useState<any[]>([]);
    const [filteredProducts, setFilteredProducts] = useState<any[]>([]);
    const [loading, setLoading] = useState(true);
    const [titleFilter, setTitleFilter] = useState('');
    const [priceFilter, setPriceFilter] = useState('');

    function applyFilters(newValue: string, filterField: string) {

        let filteredList: any[] = [];

        if (filterField === 'title') {
            if (newValue.trim() === '') {
                setTitleFilter('');
                return;
            }
            filteredList = products.filter(user =>
                user.title.toLowerCase().includes(newValue.toLowerCase())
            );

            setTitleFilter(newValue);

        } else if (filterField === 'price') {
            if (newValue.trim() === '') {
                setPriceFilter('');
                return;
            }
            filteredList = products.filter(user =>
                user.price.toString().includes(newValue.trim())
            );
            setPriceFilter(newValue);
        }

        setFilteredProducts(filteredList);
    }

    useEffect(() => {
        console.log("ProductTableFetch useEffect called");
        fetch("https://dummyjson.com/products")
            .then((res) => res.json())
            .then((data: any) => {
                console.log("Products fetched:", data);
                setProducts(data.products);
                setFilteredProducts(data.products);
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
                        <th>Product Title
                            <input type="text" value={titleFilter} onChange={(e) => applyFilters(e.target.value, 'title')} />
                        </th>
                        <th>Product Price
                            <input type="text" value={priceFilter} onChange={(e) => applyFilters(e.target.value, 'price')} />
                        </th>
                    </tr>
                </thead>
                <tbody>
                    {filteredProducts.map((product) => (
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

export default ProductTableFetchWithFiltering;
