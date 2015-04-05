#include <iostream>
#include <math.h>
using namespace std;

int factores(long int numero) {
	int cuenta = 0;
	for(int i = 1; i <= sqrt(numero); i = i+1){
		if(numero % i == 0) {
			cuenta = cuenta + 1;
			if(i != numero/i) {
				cuenta = cuenta + 1;
			}
		}
	}
	return cuenta;
}

int main() {
	long int a = 1; long int b = 1; long int temp = 0;
	while(true) {
		temp = a; a = b; b = temp + b;
		if(factores(a) >= 1000) {
			cout << a;
			return 0;
		}
	}
}