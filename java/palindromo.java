import java.io.*;
import java.lang.StringBuilder;
public class palindromo {
	public static void main(String[] args) {
		try {
			String ruta = "../string.txt";
			BufferedReader archivo = new BufferedReader(new FileReader(ruta));
			String texto = archivo.readLine();
			String palindromo = "";

			for(int i = 2; i < texto.length(); i++) {
				for(int j = 0; j < texto.length(); j++) {

					/* Restricciones. Siempre son buenas para prevenir excepciones */
					if(j + i <= texto.length()) {

						/* Obtener Fragmento */
						String fragmento = texto.substring(j, j+i-1);
						/* Chequear el Mayor Palíndromo */
						if(checkPalindromo(fragmento) && fragmento.length() > palindromo.length()) {
							palindromo = fragmento;
						}
					}
				}	
			}

			System.out.println(palindromo);

		} catch(Exception e) {
			System.out.println(e.getMessage());
			e.printStackTrace();
		}
	}	

	public static boolean checkPalindromo(String texto) {

		String reversa = new StringBuilder(texto).reverse().toString();
		return texto.equals(reversa);
	}
}