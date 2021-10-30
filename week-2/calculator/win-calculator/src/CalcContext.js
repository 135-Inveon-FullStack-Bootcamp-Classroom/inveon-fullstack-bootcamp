import React, { createContext } from "react";

export const CalcContext = createContext();

export const CalcProvider = ({ children, theme }) => {
  return <CalcContext.Provider value={{}}>{children}</CalcContext.Provider>;
};
