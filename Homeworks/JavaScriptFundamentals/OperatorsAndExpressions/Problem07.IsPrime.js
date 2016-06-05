var numbers = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0],
	i;
for (i = 0; i < numbers.length; i += 1) {
	console.log(numbers[i] + ' Is prime: ' + isPrime(numbers[i]));
}


function isPrime(number) {
	var i;
	if (number <= 1) {
		return false;
	}
	for (i = 2; i <= Math.sqrt(number); i += 1) {
		if (!(number % i)) {
			return false;
		}
	}
	return true;
}