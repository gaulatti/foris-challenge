#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <algorithm>    // std::max
using namespace std;


int main () {
	string texto;
	ifstream archivo ("../triangle.txt");
	if (archivo.is_open())
	{
		vector<string> preTriangulo;
		while(getline(archivo,texto)) { preTriangulo.push_back(texto); }

		string lineaActual;
		int triangulo [preTriangulo.size()][preTriangulo.size()];

		for(int i = 0; i < preTriangulo.size(); i = i+1){
			lineaActual = preTriangulo.at(i);
			for(int j = 0; j <= i; j = j + 1) {
				triangulo[i][j] = stoi(lineaActual.substr(j*3, 2));
			}
		}

		for (int i = preTriangulo.size() - 2; i >= 0; i--) {
			for (int j = 0; j <= i; j++) {
				triangulo[i][j] += max(triangulo[i+1][j], triangulo[i+1][j+1]);
			}
		}

		cout << triangulo[0][0];

		return 0;
	}
}