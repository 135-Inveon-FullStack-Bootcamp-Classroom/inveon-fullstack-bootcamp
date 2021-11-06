import { useEffect, useState } from "react";

import { Button, Grid, Typography } from "@mui/material";

import Layout from "./Layout";
import MemCard from "./MemeCard";

const CapsList = () => {
  const [memes, setMemes] = useState();

  const [counter, setCounter] = useState(0);

  const [counter2, setCounter2] = useState(0);

  console.log("render");

  useEffect(() => {
    fetch("https://api.imgflip.com/get_memes")
      .then((response) => response.json())
      .then((result) => setMemes(result.data.memes));
  }, []);

  useEffect(() => {
    console.log("counter 1 değişti");
  }, [counter]);

  useEffect(() => {
    console.log("counter 2 değişti");
  }, [counter2]);

  if (!memes) return <p>Loading</p>;

  return (
    <Layout>
      <Typography variant="h2">{counter}</Typography>
      <Button onClick={() => setCounter(counter + 1)}>Increse</Button>

      <Typography variant="h2">{counter2}</Typography>
      <Button onClick={() => setCounter2(counter2 + 1)}>Increse c2</Button>
      {memes.map((meme) => (
        <Grid
          container
          direction="row"
          justifyContent="center"
          alignItems="center"
        >
          <Grid item md={4}>
            <MemCard img={meme.url} title={meme.name} />
          </Grid>
        </Grid>
      ))}
    </Layout>
  );
};

export default CapsList;
