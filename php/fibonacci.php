<?php

function fibonacci() {
	$a = $b = 1;
	$temp = 0;
	while(true) {
		$temp = $a; $a = $b; $b = $temp + $b;
		if(factores($a) >= 1000) {
			print $a;
			return false;
		}
	}
}

function factores($num) {
	$divisores = [];
	for($i = 1; $i <= sqrt($num); ++$i) {
		if($num % $i == 0) {
			$divisores[] = $i;
			if($i != $num/$i) {
				$divisores[] = $num/$i;
			}
		}
	}
	return count($divisores);
}

fibonacci();