import { useEffect, useState } from "react";
import logo from "./logo.svg";
import "./App.css";

function App() {
  const [posts, setPosts] = useState();

  useEffect(() => {
    fetchMyPosts();
  }, []);

  const fetchMyPosts = async () => {
    const response = await fetch("https://jsonplaceholder.typicode.com/posts");
    const json = await response.json();

    setPosts(json);
  };

  if (!posts) return <h3>...Loading</h3>;

  return (
    <div>
      {posts.map((post) => (
        <h2>{post.title}</h2>
      ))}
    </div>
  );
}

export default App;
