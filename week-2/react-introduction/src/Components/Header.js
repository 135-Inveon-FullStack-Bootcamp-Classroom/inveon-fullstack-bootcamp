const Header = () => {
  console.log("Header rendered");
  return (
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
        borderBottom: "1px solid #ccc",
      }}
    >
      <h1>TODOS</h1>
    </div>
  );
};

export default Header;
