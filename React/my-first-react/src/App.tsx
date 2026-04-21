import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
// import FormInputValidation from './FormInputValidation'
import ProductTableFetchWithFiltering from './ProductTableFetchWithFiltering'
import ColorPreview from './ColorPreview'
import ColorInput from './ColorInput'
// import MyFirstComponent from './MyFirstComponent'
// import MySquare from './MySquare'
// import MyCounterButtons from './MyCounterButtons'
// import ProductTableFetch from './ProductTableFetch'

function App() {
  const [count, setCount] = useState(0)
  const [color, setColor] = useState("#ff0000");

  return (
    <>
      <div>
        <a href="https://vite.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      {/*
      <MyFirstComponent />
      <MySquare size={100} text="Hello" backgroundColor="lightcoral" />
     
      <hr />
      <MyCounterButtons />
      <hr />
      <MyCounterButtons />
      <hr />
      <ProductTableFetch />
      <hr />
      <FormInputValidation />
      */}

      <hr />
      <ColorInput color={color} onColorChange={setColor} />
      <ColorPreview color={color} />
      <hr />

      <ProductTableFetchWithFiltering />
      
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>

      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App
