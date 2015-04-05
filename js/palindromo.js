function palindromo() {
	fs = require('fs')
	fs.readFile('../string.txt', 'utf8', function (err,data) {
		if (err) { return console.log(err); }
		palindromo = "";

		for(i = 2; i < data.length; i++) {
			for(j = 0; j < data.length; j++) {
				if(j + i <= data.length) {
					fragmento = data.substring(j, j+i-1);
					if(checkPalindromo(fragmento) && fragmento.length > palindromo.length) {
						palindromo = fragmento;
					}
				}
			}	
		}
		console.info(palindromo);
	});
}

function checkPalindromo(txt) {
	reversa = txt.split("").reverse().join("");
	return txt == reversa;
}

palindromo();