//JavaScript file for SnakeGame. Onload it loads the canvas, changes the size and adds the background color.

var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");

//Runs when the page have loaded
window.onload = function load() {
    canvas.width = 340;
    canvas.height = 500;

    canvas.style.backgroundColor = "black";
    mainMenu();
}

//Clears the canvas
function clearCanvas() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
}

//MainMenu
function mainMenu(){
    ctx.font = "30px Arial";
    ctx.fillStyle = "grey";
    ctx.textAlign = "center";
    ctx.fillText("Snake Game", 170, 70);

    //ctx.beginPath();
    //ctx.lineWidth = "5";
    //ctx.strokeStyle = "grey";
    //ctx.rect(110, 300, 120, 40);
    //ctx.stroke();

    //ctx.font = "20px Arial";
    //ctx.fillStyle = "Grey";
    //ctx.textAlign = "center";
    //ctx.fillText("Play Game", 170, 328);
}

//Click event thats grabs the cursor location on the canvas (this changes depending on the size of the device (mobile, tablet or PC))
function click(e) {
    //alert(e.clientX + " & " + e.clientY);
    console.log(e.clientX + "," + e.clientY);
}

canvas.addEventListener("mousedown", click); 