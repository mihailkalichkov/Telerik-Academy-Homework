var stage = new Kinetic.Stage({
    container: 'canvas-container',
    width: 1350,
    height: 600
});

var xInitialBallPosition = stage.width() / 2;
var yInitialBallPosition = stage.height() / 2;
var ballRadius = 25;

var layer = new Kinetic.Layer();

var ball = new Kinetic.Circle({
    x: xInitialBallPosition,
    y: yInitialBallPosition,
    radius: ballRadius,
    stroke: 'yellow',
    fill: 'green'
});
layer.add(ball);

var xSpeed = 250;
var ySpeed = 250;
var xCoefficient = 1;     //Initial x direction: '1' for down and '-1' for up
var yCoefficient = 1;     //Initial y direction: '1' for left and '-1' for right

var animation = new Kinetic.Animation(moveLogic, layer);

function moveLogic(frame) {

    var time = frame.timeDiff / 1000;

    if (ball.x() - ballRadius < 0) {
        xCoefficient = 1;
    }
    if (ball.x() + ballRadius > stage.width()) {
        xCoefficient = -1;
    }

    if (ball.y() - ballRadius < 0) {
        yCoefficient = 1;
    }

    if (ball.y() + ballRadius > stage.height()) {
        yCoefficient = -1;
    }

    var xChange = xCoefficient * xSpeed * time;
    var yChange = yCoefficient * ySpeed * time;

    ball.setX(ball.getX() + xChange);
    ball.setY(ball.getY() + yChange);
};

animation.start();
stage.add(layer);