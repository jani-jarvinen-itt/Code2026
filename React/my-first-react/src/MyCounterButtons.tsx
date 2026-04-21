import { useState } from 'react'

function MyCounterButtons() {
    const [countA, setCountA] = useState(0);
    const [countB, setCountB] = useState(0);

    return (
        <div className="card">
            <span>Counter A: {countA}</span>
            <button onClick={() => setCountA((countA) => countA + 1)}>A</button>
            <span>Counter B: {countB}</span>
            <button onClick={() => setCountB((countB) => countB + 1)}>B</button>
        </div>
    );
}

export default MyCounterButtons;