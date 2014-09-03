var stage = new Kinetic.Stage({
    container: 'cycle',
    width: 300,
    height: 180
});

var layerCycle = createLayer(0, 0);

var firstTire = createCircle(50, 130, 40);
layerCycle.add(firstTire);
var secondTire = createCircle(240, 130, 40);
layerCycle.add(secondTire);

var cycleFrame = createPolyline(50, 130, 140, 130, 230, 75, 115, 75, 50, 130);
layerCycle.add(cycleFrame);

var cycleSeat = createPolyline(140, 130, 100, 55, 120, 55, 80, 55);
layerCycle.add(cycleSeat);

var cycleHandle = createPolyline(240, 130, 230, 75, 220, 45, 190, 30, 220, 45, 185, 55);
layerCycle.add(cycleHandle);

stage.add(layerCycle);

function createCircle(x, y, radius) {
    var bikeTier = new Kinetic.Circle({
        x: x,
        y: y,
        radius: radius,
        fill: '#90CAD7',
        stroke: '#307B8D',
        strokeWidth: 3
    });

    return bikeTier;
}

function createLayer(x, y) {
    var layer = new Kinetic.Layer({
        x: x,
        y: y
    });

    return layer;
}

function createPolyline() {
    var arr = [];

    for (var i = 0, len = arguments.length; i < len; i++) {
        arr.push(arguments[i]);
    }

    var polyline = new Kinetic.Line({
        points: arr,
        stroke: '#368699',
        strokeWidth: 2,
        lineJoin: 'round',
        closed: false
    });

    return polyline;
}