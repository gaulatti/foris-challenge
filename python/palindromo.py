#!/usr/bin python
def palindromo():
	texto = open("../string.txt", 'r').read()
	palindromo = "";

	for i in range(len(texto)):
		for j in range(len(texto)):
			if j + i <= len(texto):
				fragmento = texto[j:i]
				if (str(fragmento) == str(fragmento)[::-1]) & (len(fragmento) >= len(palindromo)):
					palindromo = fragmento

	print(palindromo)
	return
	
palindromo()