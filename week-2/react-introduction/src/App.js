import "./App.css";

const Header = () => (
  <div>
    <h2> Burası Başlık </h2>
    <p>burası da slogan</p>
  </div>
);

function renderMap() {
  return [1, 2, 3, 4, 5].map((item) => <h6>{item}</h6>);
}

function Body() {
  return (
    <div>
      <p>There is no record to show </p>
      <p>Şu an p elementi çalışıyor</p>
      {renderMap()}
    </div>
  );
}

function App() {
  return (
    <div>
      <Header />
      <hr />
      <Body />
    </div>
  );
}

export default App;
