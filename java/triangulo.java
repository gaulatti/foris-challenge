import java.util.*;
import java.io.*;
public class triangulo {
	public static void main(String[] a) {
		try {
			int[][] triangulo = leerArchivo();
			int lineas = triangulo.length;
			for(int i = lineas - 2; i >= 0; i--) {
				for(int j = 0; j <= i; j++) {
					triangulo[i][j] += Math.max(triangulo[i+1][j], triangulo[i+1][j+1]);
				}
			}
			System.out.println(triangulo[0][0]);
		} catch(Exception e) {
			System.out.println(e.getMessage());
			e.printStackTrace();
		}
	}

	public static int[][] leerArchivo() {
		try {
			String linea;
			ArrayList<String[]> lineas = new ArrayList<String[]>();
			BufferedReader archivo = new BufferedReader(new FileReader("../triangle.txt"));
			while((linea = archivo.readLine()) != null) {
				lineas.add(linea.split(" "));
			}
			int[][] triangulo = new int[lineas.size()][lineas.size()];
			for(int j = 0; j < lineas.size(); j++) {
				for(int i = 0; i <= j; i++) {
					triangulo[j][i] = Integer.parseInt(lineas.get(j)[i]);
				}
			}

			return triangulo;
		} catch(Exception e) {
			System.out.println(e.getMessage());
			e.printStackTrace();
			return new int[0][0];
		}
	}
}