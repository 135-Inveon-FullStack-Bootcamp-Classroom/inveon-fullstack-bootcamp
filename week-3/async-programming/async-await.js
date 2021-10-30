function login(username, password) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      console.log(username, password, "login yapılıyor...");
      if (username !== "murat" || password !== "1234") {
        reject("user not found");
      } else {
        resolve("1234123421oınfwuefoı12");
      }
    }, 3000);
  });
}

function getRestaurants(token) {
  return new Promise((resolve, reject) => {
    if (!token) reject("token yok!!!");
    setTimeout(() => {
      resolve(["dominos", "pizza pizza", "venedik pizza"]);
    }, 3000);
  });
}

function getMenu(restaurantName) {
  return new Promise((resolve, reject) => {
    console.log("Menu hazırlanıyor", restaurantName);
    setTimeout(() => {
      if (restaurantName === "dominos") resolve(["margarita", "turkish"]);
      if (restaurantName === "pizza pizza") resolve(["suşi"]);
      else reject("restaurant bulunamadı");
    }, 3000);
  });
}

// async function getMenuBusiness(){

// }

// const getMenuBusiness = async () => {
//   const token = await login("murat", "1234");
//   console.log(token);
//   const restaurants = await getRestaurants(token);
//   console.log(restaurants);
//   const menu = await getMenu(restaurants[1]);
//   console.log(menu);
// };

// getMenuBusiness();

// axios, fecth

const token = login("murat", "1234");
console.log(token);
const restaurants = getRestaurants(token);
console.log(restaurants);
const menu = getMenu(restaurants[1]);
console.log(menu);
