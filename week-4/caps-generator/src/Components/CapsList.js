import { useEffect, useState } from "react";

import { Button, Grid, Typography } from "@mui/material";

import Layout from "./Layout";
import MemCard from "./MemeCard";

const CapsList = () => {
  const [memes, setMemes] = useState();

  useEffect(() => {
    fetch("https://api.imgflip.com/get_memes")
      .then((response) => response.json())
      .then((result) => setMemes(result.data.memes));
  }, []);

  if (!memes) return <p>Loading</p>;

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
