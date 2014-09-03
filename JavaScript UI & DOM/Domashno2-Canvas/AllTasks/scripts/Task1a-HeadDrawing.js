var stage = new Kinetic.Stage({
    container: 'man',
    width: 150,
    height: 200
});

var layerMan = createLayer(0, 0);

var head = new Kinetic.Group();
head.add(createEllipse(70, 145, 55, 50, '#225763', '#90CAD7'));
head.add(createEllipse(80, 125, 10, 6, '#225763', '#90CAD7'));
head.add(createEllipse(76, 125, 2.5, 4.5, '', '#225763'));
head.add(createEllipse(45, 125, 10, 6, '#225763', '#90CAD7'));
head.add(createEllipse(41, 125, 2.5, 4.5, '', '#225763'));
head.add(createLine('#225763', 62, 125, 52, 155, 62, 155));
head.add(createEllipse(60, 170, 20, 7, '#225763', '#90CAD7').rotate(10));

var hat = new Kinetic.Group();
hat.add(createEllipse(70, 100, 60, 10, '#000', '#396693'));
hat.add(createEllipse(70, 90, 35, 10, '#000', '#396693'));
hat.add(createRectangle(35, 30, 70, 60, '#000', '#396693'));
hat.add(createLine('#396693', 37, 90, 103, 90));
hat.add(createEllipse(70, 30, 35, 10, '#000', '#396693'));

layerMan.add(head);
layerMan.add(hat);

stage.add(layerMan);

function createLayer(x, y) {
    var layer = new Kinetic.Layer({
        x: x,
        y: y
    });

    return layer;
}

function createEllipse(x, y, radiusX, radiusY, strokeColor, fillColor) {
    var ellipse = new Kinetic.Ellipse({
        x: x,
        y: y,
        radius: {
            x: radiusX,
            y: radiusY
        },
        stroke: strokeColor,
        fill: fillColor,
        strokeWidth: 3,
        lineJoin: 'round'
    });

    return ellipse;
}

function createRectangle(x, y, width, height, strokeColor, fillColor) {
    var rectangle = new Kinetic.Rect({
        x: x,
        y: y,
        width: width,
        height: height,
        stroke: strokeColor,
        fill: fillColor,
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