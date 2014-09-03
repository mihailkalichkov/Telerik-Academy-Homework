var stage = new Kinetic.Stage({
    container: 'house',
    width: 350,
    height: 370
});

var layerHouse = createLayer(0, 0);

var houseFundament = createPolyline(50, 350, 300, 350, 300, 160, 50, 160);
layerHouse.add(houseFundament);

var houseRoof = createPolyline(300, 160, 50, 160, 175, 25);
layerHouse.add(houseRoof);

var firstWindow = createWindow(70, 185);
layerHouse.add(firstWindow);
var secondWindow = createWindow(190, 185);
layerHouse.add(secondWindow);
var thirdWindow = createWindow(190, 265);
layerHouse.add(thirdWindow);

var houseChimney = new Kinetic.Group();
houseChimney.add(createRectangle(220, 60, 30, 70));
houseChimney.add(createEllipse(235, 60, 15, 5));
houseChimney.add(createLine('#975B5B', 215, 130, 255, 130));
layerHouse.add(houseChimney);

var houseDoor = new Kinetic.Group();
houseDoor.add(createEllipse(115, 285, 35, 20));
houseDoor.add(createRectangle(80, 285, 70, 65));
houseDoor.add(createLine('#975B5B', 82, 285, 148, 285));
houseDoor.add(createLine('#000', 115, 265, 115, 350));
houseDoor.add(createCircle(105, 325, 4));
houseDoor.add(createCircle(125, 325, 4));
layerHouse.add(houseDoor);

stage.add(layerHouse);

function createLayer(x, y) {
    var layer = new Kinetic.Layer({
        x: x,
        y: y
    });

    return layer;
}

function createCircle(x, y, radius) {
    var bikeTier = new Kinetic.Circle({
        x: x,
        y: y,
        radius: radius,
        fill: '#975B5B',
        stroke: '#000',
        strokeWidth: 3
    });

    return bikeTier;
}

function createEllipse(x, y, radiusX, radiusY) {
    var ellipse = new Kinetic.Ellipse({
        x: x,
        y: y,
        radius: {
            x: radiusX,
            y: radiusY
        },
        stroke: '#000',
        fill: '#975B5B',
        strokeWidth: 3,
        lineJoin: 'round'
    });

    return ellipse;
}

function createRectangle(x, y, width, height) {
    var rectangle = new Kinetic.Rect({
        x: x,
        y: y,
        width: width,
        height: height,
        stroke: '#000',
        fill: '#975B5B',
        strokeWidth: 3,
        lineJoin: 'round',
    });

    return rectangle;
}

function createLine(color) {
    var arr = [];

    for (var i = 1, len = arguments.length; i < len; i++) {
        arr.push(arguments[i]);
    }

    var polyline = new Kinetic.Line({
        points: arr,
        stroke: color,
        strokeWidth: 4,
        lineJoin: 'round',
        closed: false
    });

    return polyline;
}

function createPolyline() {
    var arr = [];

    for (var i = 0, len = arguments.length; i < len; i++) {
        arr.push(arguments[i]);
    }

    var polyline = new Kinetic.Line({
        points: arr,
        stroke: '#000',
        fill: '#975B5B',
        strokeWidth: 4,
        lineJoin: 'round',
        closed: true
    });

    return polyline;
}

function createWindow(x, y) {

    var elementWidth = 40;
    var elementHeight = 25;
    var spaceBetweenElements = 2;
    var elementColor = '#000';

    var window = new Kinetic.Group();

    window.add(createWindowElement(x, y));
    window.add(createWindowElement(x + elementWidth + spaceBetweenElements, y));
    window.add(createWindowElement(x, y + elementHeight + spaceBetweenElements));
    window.add(createWindowElement(x + elementWidth + spaceBetweenElements, y + elementHeight + spaceBetweenElements));

    function createWindowElement(xE, yE) {
        var windowElement = new Kinetic.Rect({
            x: xE,
            y: yE,
            width: elementWidth,
            height: elementHeight,
            fill: elementColor
        });

        return windowElement;
    }

    return window;
}