var numbers = [3, 0, 5, 7, 35, 140],
	i,
	lenght,
	divisibleBy7and5;

for (i = 0; i < numbers.length; i += 1) {
	divisibleBy7and5 = !(numbers[i] % 5) && !(numbers[i] % 7);
	console.log(numbers[i] + ' is divisible By 7 and 5 ' + divisibleBy7and5);
}