#include <iostream>
#include <fstream>
using namespace std;

bool checkPalindromo(string fragmento) {
	string reversa = string(fragmento.rbegin(), fragmento.rend());
	return (fragmento == reversa);
}

int main () {
	string texto;
	ifstream archivo ("../string.txt");
	if (archivo.is_open())
	{
		getline(archivo,texto);
		string palindromo; 
		for(int i = 2; i < texto.size(); i = i+1) {
				for(int j = 0; j < texto.size(); j = j+1) {
					if(j + i <= texto.size()) {
						string fragmento = texto.substr(j, i);
						if(checkPalindromo(fragmento) && fragmento.size() > palindromo.size()) {
							palindromo = fragmento;
						}
					}
				}	
			}

		cout << palindromo;
		archivo.close();
	}

	else cout << "Houston! No puedo abrir el txt"; 

	return 0;
}

