var trapezoids = [{
		a: 5,
		b: 7,
		h: 12
	}, {
		a: 2,
		b: 1,
		h: 33
	}, {
		a: 8.5,
		b: 4.3,
		h: 2.7
	}, {
		a: 100,
		b: 200,
		h: 300
	}, {
		a: 0.222,
		b: 0.333,
		h: 0.555
	}],
	area;

for (var i = 0; i < trapezoids.length; i += 1) {
	area = trapezoidArea(trapezoids[i].a, trapezoids[i].b, trapezoids[i].h);
	console.log('a: ' + trapezoids[i].a + ' b: ' + trapezoids[i].b + ' h: ' + trapezoids[i].h + ' area: ' + Math.round(area * 10000000) / 10000000);
}

function trapezoidArea(a, b, h) {
	return (a + b) / 2 * h;
}