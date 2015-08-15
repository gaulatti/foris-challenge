using System;
using System.IO;
using System.Text;
using System.Collections;

class Triangulo {
	public static void Main() {
		int[,] txtTriangulo = LeerArchivo("../triangle.txt");
		int lineas = txtTriangulo.GetLength(0);

		/* Si desde el principio no resulta, parte desde el final! */
		for (int i = lineas - 2; i >= 0; i--) {
			for (int j = 0; j <= i; j++) {
				txtTriangulo[i, j] += Math.Max(txtTriangulo[i+1,j], txtTriangulo[i+1, j+1]);
			}
		}

		/* He llegado hasta Taltal! */
		Console.WriteLine(txtTriangulo[0,0]);
	}

	private static int[,] LeerArchivo(string txt) {
		string linea;
		string[] fragmentos;
		int lineas = 0;

		// Leer el Archivo y Contar Líneas en tiempo real
		StreamReader r = new StreamReader(txt);
		while ((linea = r.ReadLine()) != null) {
			lineas++;
		}

		int[,]  triangulo = new int[lineas, lineas];
		r.BaseStream.Seek(0, SeekOrigin.Begin);

		int j = 0;
		while ((linea = r.ReadLine()) != null) {
			fragmentos = linea.Split(' ');
			for (int i = 0; i < fragmentos.Length; i++) {
				triangulo[j, i] = int.Parse(fragmentos[i]);
			}
			j++;
		}
		r.Close();
		return triangulo;
	}
}