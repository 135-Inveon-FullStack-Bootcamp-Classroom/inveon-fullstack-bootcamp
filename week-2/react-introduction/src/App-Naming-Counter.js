import React, { useState } from "react";
import Counter from "./Counter";
import Naming from "./Naming";

function App() {
  console.log("App Rendered");
  const [counter, setCounter] = useState(0);

  return (
    <div>
      <Naming />
      <Counter
        counter={counter}
        setCounter={setCounter}
        title="My Counter"
        description="This is a counter"
      />
      <Counter
        counter={counter}
        setCounter={setCounter}
        title="my second counter"
        description="This is not counter"
      />
    </div>
  );
}

export default App;
