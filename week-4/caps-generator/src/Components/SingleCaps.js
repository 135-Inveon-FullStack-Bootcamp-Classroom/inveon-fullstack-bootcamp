import { CircularProgress, Typography } from "@mui/material";
import styled from "@emotion/styled";

import { useParams } from "react-router-dom";
import { useMemesContext } from "../Contexts/MemesContext";
import Layout from "./Layout";

// const Image = styled.img`
//   max-height: 400px;
//   border: 1px solid #333;
//   border-radius: 5px;
// `;

const Image = styled.img((props) => ({
  maxHeight: 400,
  border: "1px solid #333",
  borderRadius: props.borderRadius,
}));

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
      <Typography variant="h2">{meme.name}</Typography>
      <Image src={meme.url} alt={meme.name} borderRadius={35} />
    </Layout>
  );
};

export default SingleCaps;
