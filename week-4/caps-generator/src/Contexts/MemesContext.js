import { createContext, useContext, useState } from "react";

export const MemesContext = createContext();

const MemesProvider = ({ children }) => {
  const [memes, setMemes] = useState();

  return (
    <MemesContext.Provider value={{ memes, setMemes }}>
      {children}
    </MemesContext.Provider>
  );
};

export default MemesProvider;
