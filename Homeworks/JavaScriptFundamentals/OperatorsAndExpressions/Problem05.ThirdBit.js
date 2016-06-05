var numbers = [5, 8, 0, 15, 5343, 62241],
	i,
	lenght;

for (i = 0; i < numbers.length; i += 1) {

	console.log('Number: ' + numbers[i] + ' Third bit:' + (((numbers[i]) >> 3) & 1));
}