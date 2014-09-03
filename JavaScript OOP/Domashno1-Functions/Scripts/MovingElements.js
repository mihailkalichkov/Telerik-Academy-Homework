var addCircleBtn = document.getElementById('addCircle');
addCircleBtn.addEventListener('click', function () {
    movingShapes.add('ellipse');
}, false);
var addCircleBtn = document.getElementById('addRect');
addCircleBtn.addEventListener('click', function () {
    movingShapes.add('rect');
}, false);
var moveBtn = document.getElementById('moveBtn');
moveBtn.addEventListener('click', function () {
    movingShapes.move();
}, false);