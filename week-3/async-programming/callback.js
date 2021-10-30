console.log("begin");

function login(username, password, callback) {
  setTimeout(() => {
    console.log(username, password, "login yapılıyor...");
    callback("1234123421oınfwuefoı12");
  }, 3000);
}

function getRestaurants(token, sonucAl) {
  if (!token) throw Error("token yok");
  setTimeout(() => {
    console.log("restorantlar hazırlanıyor");
    sonucAl(["dominos", "pizza pizza", "venedik pizza"]);
  }, 3000);
}
function getMenu(restaurantName, callback) {
  console.log("Menu hazırlanıyor", restaurantName);
  setTimeout(() => {
    if (restaurantName === "dominos") callback(["margarita", "turkish"]);
    if (restaurantName === "pizza pizza") callback(["suşi"]);
  });
}

login("murat", 1234, (token) => {
  getRestaurants(token, (restaurants) => {
    getMenu(restaurants[0], (menu) => {
      console.log(menu);
    });
  });
});

// const menu = getMenu(restaurants[0]);

// console.log(menu);
console.log("end");
