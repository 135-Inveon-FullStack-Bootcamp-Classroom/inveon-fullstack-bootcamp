import React, { createContext } from "react";

export const CalcContext = createContext();

const lightTheme = {
  background: "#fff",
};
const darkTheme = {
  background: "#000",
};

export const CalcProvider = ({ children, theme }) => {
  return (
    <CalcContext.Provider
      value={{ theme: theme === "light" ? lightTheme : darkTheme }}
    >
      {children}
    </CalcContext.Provider>
  );
};
