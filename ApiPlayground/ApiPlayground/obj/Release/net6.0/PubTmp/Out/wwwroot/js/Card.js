var code = document.getElementById("code").innerHTML;
var PictureLink = document.getElementById("weatherPic");

window.onload = function changeRef() {
    PictureLink.setAttribute('src', "https://openweathermap.org/img/wn/" + code + ".png");
};