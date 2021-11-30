var x = document.getElementById("Test")

function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    } else {
        x.innerHTML = "Geolocation is not supported by this browser.";
    }
}

function showPosition(position) {
    var lat = position.coords.latitude;
    var longt = position.coords.longitude;

    //x.innerHTML = lat + " " + longt

    var request = new XMLHttpRequest;

    request.open("GET", '/Weather/GetWeather?lat='+lat+'&longt='+longt);

    //request.open("GET", '/Weather/GetWeather?lat=${lat}&longt=${longt}');

    request.onreadystatechange = function () {
        // Check if the request is compete and was successful
        if (this.readyState === 4 && this.status === 200) {
            // Inserting the response from server into an HTML element
            x.innerHTML = this.responseText;
        } else {
            x.innerHTML = "THIS DIDNT WORK"
        }
    };

    request.send();

    //x.innerHTML = "Latitude: " + lat +
    //    "<br>Longitude: " + long;
}