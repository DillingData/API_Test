var code = document.getElementById("code").innerHTML;
var PictureLink = document.getElementById("weatherPic");

var card1state = 0;
var card2state = 0;
var card3state = 0;
var card4state = 0;
var card5state = 0;
var card6state = 0;
var card7state = 0;

window.onload = function changeRef() {
    PictureLink.setAttribute('src', "https://openweathermap.org/img/wn/" + code + ".png");
}
function onclickday1() {
    if (card1state == 0) {
        document.getElementById("body1").style.display = "block";
        card1state = 1;
    } else {
        document.getElementById("body1").style.display = "none";
        card1state = 0;
    }
}
function onclickday2() {
    if (card2state == 0) {
        document.getElementById("body2").style.display = "block";
        card2state = 1;
    } else {
        document.getElementById("body2").style.display = "none";
        card2state = 0;
    }
}
function onclickday3() {
    if (card3state == 0) {
        document.getElementById("body3").style.display = "block";
        card3state = 1;
    } else {
        document.getElementById("body3").style.display = "none";
        card3state = 0;
    }
}
function onclickday4() {
    if (card4state == 0) {
        document.getElementById("body4").style.display = "block";
        card4state = 1;
    } else {
        document.getElementById("body4").style.display = "none";
        card4state = 0;
    }
}
function onclickday5() {
    if (card5state == 0) {
        document.getElementById("body5").style.display = "block";
        card5state = 1;
    } else {
        document.getElementById("body5").style.display = "none";
        card5state = 0;
    }
}
function onclickday6() {
    if (card6state == 0) {
        document.getElementById("body6").style.display = "block";
        card6state = 1;
    } else {
        document.getElementById("body6").style.display = "none";
        card6state = 0;
    }
}
function onclickday7() {
    if (card7state == 0) {
        document.getElementById("body7").style.display = "block";
        card7state = 1;
    } else {
        document.getElementById("body7").style.display = "none";
        card7state = 0;
    }
}
