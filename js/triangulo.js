function triangulo() {
	fs = require('fs')
	fs.readFile('../triangle.txt', 'utf8', function (err,data) {
		if (err) { return console.log(err); }
		triangulo = data.split("\n").map(function(x) {
			return x.split(" ").map(function(y) { return parseInt(y);});
		});

		for(i = triangulo.length - 2; i >= 0; i--) {
			for(j = 0; j <= i; j++) {
				triangulo[i][j] += Math.max(triangulo[i+1][j], triangulo[i+1][j+1]);
			}
		}
		console.info(triangulo[0][0]);
	});
}

triangulo();