var code = document.getElementById("code").innerHTML;
var PictureLink = document.getElementById("weatherPic");

const weekday = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

const d = new Date();
let day = weekday[d.getDay()];

window.onload = function changeRef() {
    PictureLink.setAttribute('src', "https://openweathermap.org/img/wn/" + code + ".png");
};