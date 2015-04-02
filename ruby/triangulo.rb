def triangulo()
	texto = File.new("../triangle.txt", "r")
	triangulo = [[]]

	while (linea = texto.gets)
		triangulo << linea.split(' ')
	end

	triangulo.shift

	rango = triangulo.length - 2..0

	(rango.first).downto(rango.last).each { |i| 
		for j in 0..i + 1
			triangulo[i][j] = triangulo[i][j].to_i + [triangulo[i+1][j].to_i, triangulo[i+1][j+1].to_i].max
		end
	}
	puts triangulo[0][0]
end

triangulo()