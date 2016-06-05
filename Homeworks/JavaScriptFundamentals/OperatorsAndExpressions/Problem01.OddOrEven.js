var numbers = [3, 2, -2, -1, 0],
	i,
	lenght;

for (i = 0; i < numbers.length; i += 1) {
	console.log(numbers[i] + ' Odd? ' + !!(numbers[i] % 2));
}