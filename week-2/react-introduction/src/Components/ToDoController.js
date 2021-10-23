const ToDoController = ({ inputValue, setInputValue, buttonClick }) => (
  <div>
    <input value={inputValue} onChange={(e) => setInputValue(e.target.value)} />
    <button onClick={buttonClick}>Save</button>
  </div>
);

export default ToDoController;
