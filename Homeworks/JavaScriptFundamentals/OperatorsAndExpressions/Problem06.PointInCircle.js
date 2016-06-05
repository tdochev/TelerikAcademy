var points = [{
		x: 0,
		y: 1
	}, {
		x: -5,
		y: 0
	}, {
		x: -4,
		y: 5
	}, {
		x: 1.5,
		y: -3
	}, {
		x: -4,
		y: -3.5
	}, {
		x: 100,
		y: -30
	}, {
		x: 0,
		y: 0
	}, {
		x: 0.2,
		y: -0.8
	}, {
		x: 0.9,
		y: -4.93
	}, {
		x: 2,
		y: 2.655
	}],
	r = 5,
	cx = 0,
	cy = 0,
	i,
	isInC;

function isInCircle(x, y, cx, cy, r) {
	return (x - cx) * (x - cx) + (y - cy) * (y - cy) <= r * r;
}
for (i = 0; i < points.length; i += 1) {
	isInC = isInCircle(points[i].x, points[i].y, cx, cy, r);
	console.log('x: ' + points[i].x + ' y: ' + points[i].y + ' inside: ' + isInC);
}