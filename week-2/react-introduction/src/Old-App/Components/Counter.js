import React, { useState } from "react";
import CounterTitle from "./CounterTitle";

function Counter({ title, description, counter, setCounter }) {
  console.log("Counter rendered", counter);

  function counterIncrease() {
    setCounter(counter + 1);
  }

  function counterDecrease() {
    setCounter(counter - 1);
  }

  return (
    <div>
      <CounterTitle title="Patika" description="Inveon Bootcamp" />
      <CounterTitle title="Dev" description="Inveon Bootcamp" />
      <CounterTitle title={title} description={description} />
      <button onClick={counterIncrease}> Artır </button>
      <h2>{counter}</h2>
      <button onClick={counterDecrease}> Azalt </button>
    </div>
  );
}

export default Counter;
