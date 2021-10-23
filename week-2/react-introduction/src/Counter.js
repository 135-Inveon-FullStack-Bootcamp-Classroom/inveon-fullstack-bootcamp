import React, { useState } from "react";

function Counter() {
  let [counter, setCounter] = useState(0);
  //   const [x, y, ...rest] = [1, 2, 3, 4, 5];

  console.log("Counter rendered", counter);

  function counterIncrease() {
    setCounter(counter + 1);
  }

  function counterDecrease() {
    setCounter(counter - 1);
  }

  return (
    <div>
      <button onClick={counterIncrease}> Artır </button>
      <h2>{counter}</h2>
      <button onClick={counterDecrease}> Azalt </button>
    </div>
  );
}

export default Counter;
