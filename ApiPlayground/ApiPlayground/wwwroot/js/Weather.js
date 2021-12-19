var x = document.getElementById("Test");
var link = document.getElementById("WeatherLink")

window.onload = function myFunction() {
    if (confirm("You must allow location services for this page to work properly")) {
        getLocation();
    } else {
        link.classList.add("disabled")
    }
}

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

    //shortens the Lat/Long to 2 decimals
    var latShort = lat.toFixed(2);
    var longShort = longt.toFixed(2);

    var request = new XMLHttpRequest;

    //for published version
    //request.open("GET", '/ApiPlayground/Weather/StoreCoord?lat=' + latShort + '&longt=' + longShort);

    //for dev version on local host
    //request.open("GET", '/Weather/GetWeather?lat=' + latShort + '&longt=' + longShort);

    //Testing for OnGet method
    request.open("GET", 'Weather/StoreCoord?lat=' + latShort + '&longt=' + longShort);


    request.onreadystatechange = function () {
        // Check if the request is compete and was successful
        if (this.readyState === 4 && this.status === 200) {
            // Inserting the response from server into an HTML element
            //x.innerHTML = this.responseText;
        } else {
            x.innerHTML = "THIS DIDNT WORK"
        }
    };
    request.send();
}