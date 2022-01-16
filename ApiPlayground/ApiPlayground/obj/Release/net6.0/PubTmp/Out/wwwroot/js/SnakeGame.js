var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");

window.onload = function load() {
    //canvas.style.width = "340px";
    //canvas.style.height = "500px";

    canvas.width = 340;
    canvas.height = 500;

    canvas.style.backgroundColor = "black";
    mainMenu();
}


function mainMenu(){
    ctx.font = "30px Arial";
    ctx.fillStyle = "grey";
    ctx.textAlign = "center";
    ctx.fillText("Snake Game", 170, 70);

    ctx.beginPath();
    ctx.lineWidth = "5";
    ctx.strokeStyle = "grey";
    ctx.rect(110, 300, 120, 40);
    ctx.stroke();

    ctx.font = "20px Arial";
    ctx.fillStyle = "Grey";
    ctx.textAlign = "center";
    ctx.fillText("Play Game", 170, 328);
}