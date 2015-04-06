<?php
function palindromo() {
	$data = file_get_contents("../string.txt");
	$palindromo = "";

	for($j = 0; $j < strlen($data); $j++) {
		for($i = 2; $i < strlen($data); $i++) {
			if($j + $i <= strlen($data)) {
				$fragmento = substr($data, $j, $i);
				if(($fragmento == strrev($fragmento)) && (strlen($fragmento) > strlen($palindromo))) {
					$palindromo = $fragmento;
				}
			}
		}	
	}
	print($palindromo);
}
palindromo();