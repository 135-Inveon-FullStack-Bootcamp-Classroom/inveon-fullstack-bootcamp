import React, { useState } from "react";

function Naming() {
  const [name, setName] = useState("Berke");

  console.log("Naming rendered", name);

  return (
    <>
      <input
        type="input"
        value={name}
        onChange={(e) => setName(e.target.value)}
      />
      <h2>{name}</h2>
    </>
  );
}

export default Naming;
