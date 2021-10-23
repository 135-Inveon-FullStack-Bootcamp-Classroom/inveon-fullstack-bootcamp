import React from "react";
import Counter from "./Counter";
import Naming from "./Naming";

function App() {
  console.log("App Rendered");
  return (
    <div>
      <Counter />
      <Counter />
      <Counter />
      <Counter />
      <Counter />
      <Counter />
      <Naming />
      <Naming />
      <Naming />
      <Naming />

      <Counter />
      <Counter />
      <Counter />

    </div>
  );
}

export default App;
