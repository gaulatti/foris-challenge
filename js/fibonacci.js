function fibonacci() {
	a = b = 1;
	temp = 0;
	while(true) {
		temp = a; a = b; b = temp + b;
		if(factores(a) >= 1000) {
			console.log(a);
			return false;
		}
	}
}

function factores(num) {
	divisores = [];
	for(i = 1; i <= Math.sqrt(num); ++i) {
		if(num % i == 0) {
			divisores.push(i);
			if(i != num/i) {
				divisores.push(num/i);
			}
		}
	}
	return divisores.length;
}

fibonacci();