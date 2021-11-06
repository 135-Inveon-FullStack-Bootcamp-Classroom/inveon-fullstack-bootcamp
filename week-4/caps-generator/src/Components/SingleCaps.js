import { CircularProgress } from "@mui/material";
import { useParams } from "react-router-dom";
import { useMemesContext } from "../Contexts/MemesContext";
import Layout from "./Layout";

const SingleCaps = () => {
  const { id } = useParams();

  const { getMemeById } = useMemesContext();

  const meme = getMemeById(id);

  if (!meme)
    return (
      <Layout>
        <CircularProgress />
      </Layout>
    );

  return (
    <Layout>
      <h2>Single Caps</h2>
      <pre>{JSON.stringify(meme, 4, null)}</pre>
    </Layout>
  );
};

export default SingleCaps;
