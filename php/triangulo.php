<?php
function triangulo() {
	$triangulo = array_map(function($item) {
		return explode(" ", $item);
	}, file("../triangle.txt"));

	for($i = count($triangulo) - 2; $i >= 0; $i--) {
		for($j = 0; $j <= $i; $j++) {
			$triangulo[$i][$j] += max($triangulo[$i+1][$j], $triangulo[$i+1][$j+1]);
		}
	}

	print($triangulo[0][0]);
}
triangulo();