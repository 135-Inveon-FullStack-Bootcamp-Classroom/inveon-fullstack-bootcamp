import { createContext } from "react";

const MemesContext = createContext();

const MemesProvider = ({ children }) => {
  return <MemesContext.Provider>{children}</MemesContext.Provider>;
};

export default MemesProvider;
