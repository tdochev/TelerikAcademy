var numbers = [5, 701, 1732, 9703, 877, 777877, 9999799],
	i,
	lenght,
	thirdDigitIs7;

for (i = 0; i < numbers.length; i += 1) {
	thirdDigitIs7 = (numbers[i] / 100 % 10 | 0) === 7;
	console.log(numbers[i] + ' thirdDigitIs7 ' + thirdDigitIs7);
}