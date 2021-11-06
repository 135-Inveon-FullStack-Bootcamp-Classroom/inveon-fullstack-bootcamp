import { useParams } from "react-router-dom";
import Layout from "./Layout";

const SingleCaps = () => {
  const { id } = useParams();

  return (
    <Layout>
      <h2>Single Caps</h2>
    </Layout>
  );
};

export default SingleCaps;
