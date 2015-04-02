#!/usr/bin python
def triangulo():
	texto = open("../triangle.txt", 'r').read()

	lineas = filter(None, texto.split('\n'))
	triangulo = [[]]

	for i in range(len(lineas)):
		items = lineas[i].split(' ')
		triangulo.append(items)
	
	triangulo.pop(0)

	for j in reversed(range(0, len(triangulo) - 1)):
		for k in range(0, j + 1):
			triangulo[j][k] = int(triangulo[j][k]) + int(max(triangulo[j+1][k], triangulo[j+1][k+1]))

	print triangulo[0][0]
	return

triangulo()