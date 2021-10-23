import React, { useState } from "react";
import Header from "./Components/Header";
import ToDoController from "./Components/ToDoController";
import ToDoList from "./Components/ToDoList";

function App() {
  const [inputValue, setInputValue] = useState("");
  const [todos, setTodos] = useState([]);

  // haftada bir yapılcak gibi

  /**
   * [
   *   {text, status, date,
   *   type: "periyodik/tek seferlik",}]
   */

  //
  //
  //
  //

  // todoItem = {text, status, date}

  return (
    <div>
      <Header />
      <ToDoController
        inputValue={inputValue}
        setInputValue={setInputValue}
        buttonClick={() => {
          const myNewTodo = {
            text: inputValue,
            status: "active",
            startDate: new Date(),
            endDate: new Date(), // 3 gün sonrası
          };
          setTodos([...todos, myNewTodo]);
        }}
      />
      <ToDoList todos={todos} setTodos={setTodos} />
    </div>
  );
}

export default App;
