// const promise = new Promise((resolve, reject) => {
//   setTimeout(() => {
//     if (x < 21) {
//       reject("21 yaşından küçükler giremez");
//     } else resolve("giriniz...");
//   }, 3000);
// });

// promise
// .then((sonuc) => console.log(sonuc))
// .then(ess)
// .then()
// .catch()
// .finally();

// promise.then((sonuc) => console.log(sonuc));
//   .catch((error) => console.log(error));

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

// normal notasyon
// login("murat", "12344")
//   .then((token) => getRestaurants(token))
//   .then((restaurants) => getMenu(restaurants[0]))
//   .then((menu) => console.log(menu))
//   .catch((error) => console.error("error!!", error))
//   .finally(() => console.log("işlem bitirildi"));

login("murat", "1234").then((token) => {
  getRestaurants(token).then((restaurants) => {
    getMenu(restaurants[1]).then((menu) => {
      console.log(menu);
      console.log(restaurants);
      console.log(token);
    });
  });
});
