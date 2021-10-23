const ToDoList = ({ todos, setTodos }) => {
  return (
    <ul>
      {todos.map((item, index) => (
        <li key={item.text + index}>
          {item.text}
          <button
            onClick={() => {
              const newTodos = [
                ...todos.filter((filterItem) => filterItem.text !== item.text),
              ];
              setTodos(newTodos);
            }}
          >
            Sil
          </button>
          <label for="haftalik">Haftalik</label>
          <input
            type="radio"
            id="haftalik"
            name="fav_language"
            value="Haftalik"
          />
          <label for="html">Aylik</label>
          <input type="radio" id="aylik" name="fav_language" value="Aylik" />
        </li>
      ))}
    </ul>
  );
};

export default ToDoList;
