def palindromo()
	texto = File.new("../string.txt", "r").gets
	palindromo = ""

	for i in 0..texto.length
		for j in 0..texto.length
			if (j + i) <= texto.length
				fragmento = texto[j..i]
				if(fragmento == fragmento.reverse) & (fragmento.length > palindromo.length)
					palindromo = fragmento
				end
			end
		end
	end
	puts palindromo
end

palindromo()