import { CircularProgress, Grid } from "@mui/material";

import Layout from "./Layout";
import MemCard from "./MemeCard";

import { useMemesContext } from "../Contexts/MemesContext";

const CapsList = () => {
  const { memes } = useMemesContext();

  if (!memes)
    return (
      <Layout>
        <CircularProgress />
      </Layout>
    );

  console.log({ memes });

  return (
    <Layout>
      <Grid
        container
        direction="row"
        justifyContent="center"
        alignItems="center"
      >
        {memes.map((meme) => (
          <Grid item md={4}>
            <MemCard img={meme.url} title={meme.name} />
          </Grid>
        ))}
      </Grid>
    </Layout>
  );
};

export default CapsList;
