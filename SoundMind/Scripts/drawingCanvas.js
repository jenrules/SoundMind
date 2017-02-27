var canvas = document.getElementById("canvas");
var context = canvas.getContext("2d");
var radius = 10;
var dragging = false;
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;
window.onresize = function () {
    var image = context.getImageData(0, 0, canvas.width, canvas.height);
    canvas.width = window.innerWidth;
    canvas.height = window.innerHeight;
    context.putImageData(image, 0, 0);
}
function clearCanvas(canvas) {
    canvas.width = canvas.width;
}
context.lineWidth = radius * 2;
var putPoint = function (e) {
    if (dragging) {
        context.lineTo(e.clientX, e.clientY);
        context.stroke();
        context.beginPath();
        context.arc(e.clientX, e.clientY, radius, 0, Math.PI * 2);
        context.fill();
        context.beginPath();
        context.moveTo(e.clientX, e.clientY);
    }
}
var engage = function (e) {
    dragging = true;
    putPoint(e);
}
var disengage = function () {
    dragging = false;
    context.beginPath();
}
canvas.addEventListener("mousedown", engage);
canvas.addEventListener("mousemove", putPoint);
canvas.addEventListener("mouseup", disengage);
//radius.js
var setRadius = function (newRadius) {
    if (newRadius < minRad)
        newRadius = minRad;
    else if (newRadius > maxRad)
        newRadius = maxRad;
    radius = newRadius;
    context.lineWidth = radius * 2;
    radSpan.innerHTML = radius;
}
var minRad = 5,
 maxRad = 50,
 defaultRad = 20,
 interval = 5,
 radSpan = document.getElementById("radval");
decRad = document.getElementById("decrad");
incRad = document.getElementById("incrad");
decRad.addEventListener("click", function () {
    setRadius(radius - interval);
});
incRad.addEventListener("click", function () {
    setRadius(radius + interval);
});
setRadius(defaultRad);
//colors.js
var colors = ["black", "grey", "white", "red", "orange", "yellow", "green", "blue", "violet"];
for (var i = 0, n = colors.length; i < n; i++) {
    var swatch = document.createElement("div");
    swatch.className = "swatch";
    swatch.style.backgroundColor = colors[i];
    swatch.addEventListener("click", setSwatch);
    document.getElementById("colors").appendChild(swatch);
}
function setColor(color) {
    context.fillStyle = color;
    context.strokeStyle = color;
    var active = document.getElementsByClassName("active")[0];
    if (active) {
        active.className = "swatch";
    }
}
function setSwatch(e) {
    var swatch = e.target;
    setColor(swatch.style.backgroundColor);
    swatch.className += " active";
}
setSwatch({ target: document.getElementsByClassName("swatch")[0] });
//save.js

var saveButton = document.getElementById("save");
saveButton.addEventListener("click", saveImage);
function saveImage() {
    var image = canvas.toDataURL();
    window.open(image, "_image", "location=0, menubar=0");
}

