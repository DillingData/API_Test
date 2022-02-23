//JavaScript file for SnakeGame. Onload it loads the canvas, changes the size and adds the background color.

var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");

class Player {
    constructor() {
        this.position = {
            x: 170,
            y: 70
        }
        this.width = 10;
        this.height = 10;
    }

    draw() {
        ctx.fillRect(this.position.x, this.position.y, this.width, this.height)
        ctx.fillStyle = "grey";
    }
}

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
}

//Run the game
function runGame() {
    clearCanvas();
    animate();
}

const player = new Player();

//animation loop
function animate() {
    requestAnimationFrame(animate);
    player.draw();
}