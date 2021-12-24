var code = document.getElementById("code").innerHTML;
var PictureLink = document.getElementById("weatherPic");

window.onload = function changeRef() {
    PictureLink.setAttribute('src', "https://openweathermap.org/img/wn/" + code + ".png");
    
};

function sendWeekday() {


    var request = new XMLHttpRequest;

    //for published version
    request.open("GET", '/ApiPlayground/Weather/StoreCoord?lat=' + latShort + '&longt=' + longShort);

    //For developer version
    //request.open("GET", 'Weather/StoreCoord?lat=' + latShort + '&longt=' + longShort);


    request.onreadystatechange = function () {
        // Check if the request is compete and was successful
        if (this.readyState === 4 && this.status === 200) {
            // Inserting the response from server into an HTML element
            //x.innerHTML = this.responseText;
        } else {
            //x.innerHTML = "THIS DIDNT WORK"
        }
    };
    request.send();
}