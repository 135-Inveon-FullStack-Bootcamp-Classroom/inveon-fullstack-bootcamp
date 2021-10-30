const doublex = () => {
  setTimeout(() => {
    x = x * 2;
  }, 3000);
};

let x = 25;
doublex();

console.log(x);
