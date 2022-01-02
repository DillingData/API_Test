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
    getday();
}

function getday() {
    const d = new Date();
    let day = d.getDay();

    if (day == 0)
    {
        document.getElementById("day1").innerHTML = "Sunday ";
        document.getElementById("day2").innerHTML = "Monday ";
        document.getElementById("day3").innerHTML = "Tuesday ";
        document.getElementById("day4").innerHTML = "Wednesday ";
        document.getElementById("day5").innerHTML = "Thursday ";
        document.getElementById("day6").innerHTML = "Friday ";
        document.getElementById("day7").innerHTML = "Saturday ";
    }
    if (day == 1) {
        document.getElementById("day1").innerHTML = "Monday ";
        document.getElementById("day2").innerHTML = "Tuesday ";
        document.getElementById("day3").innerHTML = "Wednesday ";
        document.getElementById("day4").innerHTML = "Thursday ";
        document.getElementById("day5").innerHTML = "Friday ";
        document.getElementById("day6").innerHTML = "Saturday ";
        document.getElementById("day7").innerHTML = "Sunday ";
    } if (day == 2) {
        document.getElementById("day1").innerHTML = "Tuesday ";
        document.getElementById("day2").innerHTML = "Wednesday ";
        document.getElementById("day3").innerHTML = "Thursday ";
        document.getElementById("day4").innerHTML = "Friday ";
        document.getElementById("day5").innerHTML = "Saturday ";
        document.getElementById("day6").innerHTML = "Sunday ";
        document.getElementById("day7").innerHTML = "Monday ";
    } if (day == 3) {
        document.getElementById("day1").innerHTML = "Wednesday ";
        document.getElementById("day2").innerHTML = "Thursday ";
        document.getElementById("day3").innerHTML = "Friday ";
        document.getElementById("day4").innerHTML = "Saturday ";
        document.getElementById("day5").innerHTML = "Sunday ";
        document.getElementById("day6").innerHTML = "Monday ";
        document.getElementById("day7").innerHTML = "Tuesday ";
    } if (day == 4) {
        document.getElementById("day1").innerHTML = "Thursday ";
        document.getElementById("day2").innerHTML = "Friday ";
        document.getElementById("day3").innerHTML = "Saturday ";
        document.getElementById("day4").innerHTML = "Sunday ";
        document.getElementById("day5").innerHTML = "Monday ";
        document.getElementById("day6").innerHTML = "Tuesday ";
        document.getElementById("day7").innerHTML = "Wednesday ";
    } if (day == 5) {
        document.getElementById("day1").innerHTML = "Friday ";
        document.getElementById("day2").innerHTML = "Saturday ";
        document.getElementById("day3").innerHTML = "Sunday ";
        document.getElementById("day4").innerHTML = "Monday ";
        document.getElementById("day5").innerHTML = "Tuesday ";
        document.getElementById("day6").innerHTML = "Wednesday ";
        document.getElementById("day7").innerHTML = "Thursday ";
    } if (day == 6) {
        document.getElementById("day1").innerHTML = "Saturday ";
        document.getElementById("day2").innerHTML = "Sunday ";
        document.getElementById("day3").innerHTML = "Monday ";
        document.getElementById("day4").innerHTML = "Tuesday ";
        document.getElementById("day5").innerHTML = "Wednesday ";
        document.getElementById("day6").innerHTML = "Thursday ";
        document.getElementById("day7").innerHTML = "Friday ";
    } if (day == 7) {
        document.getElementById("day1").innerHTML = "Sunday ";
        document.getElementById("day2").innerHTML = "Monday ";
        document.getElementById("day3").innerHTML = "Tuesday ";
        document.getElementById("day4").innerHTML = "Wednesday ";
        document.getElementById("day5").innerHTML = "Thursday ";
        document.getElementById("day6").innerHTML = "Friday ";
        document.getElementById("day7").innerHTML = "Saturday ";
    }
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