import CapsList from "./Components/CapsList";
import SingleCaps from "./Components/SingleCaps";

import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

function App(props) {
  console.log({ props });
  return (
    <Router>
      <Routes>
        <Route path="/" element={<CapsList />} />
        <Route path="/single-caps" element={<SingleCaps />} />
      </Routes>
    </Router>
  );
}

export default App;
