var points = [{
		x: 1,
		y: 4
	}, {
		x: 3,
		y: 2
	}, {
		x: 0,
		y: 1
	}, {
		x: 4,
		y: 1
	}, {
		x: 2,
		y: 0
	}, {
		x: 4,
		y: 0
	}, {
		x: 2.5,
		y: 1.5
	}, {
		x: 3.5,
		y: 1.5
	}, {
		x: -100,
		y: -100
	}, ],
	isInC,
	isOutRec;

function isInCircle(x, y) {
	var cx = 0,
		cy = 0,
		r = 5;
	return (x - cx) * (x - cx) + (y - cy) * (y - cy) <= r * r;
}

function isOutsideRectangle(x, y) {
	return ((x < -1) || (x > 5) || (y > 1) || (y < -1));
}

for (var i = 0; i < points.length; i++) {
	isInC = isInCircle(points[i].x, points[i].y);
	isOutRec = isOutsideRectangle(points[i].x, points[i].y);
	console.log(points[i].x + ' ' + points[i].y + ' ' + (isInC && isOutRec ? 'yes' : 'no'));
}