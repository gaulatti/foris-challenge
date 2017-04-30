import java.io.*;
import java.lang.StringBuilder;
public class Palindromo {
	public static void main(String[] args) {
		try {
			String texto = new BufferedReader(new FileReader("../string.txt")).readLine();
			String palindromo = "";
			for(int i = 2; i < texto.length(); i++) {
				for(int j = 0; j < texto.length(); j++) {
					if(j + i <= texto.length()) {
						String fragmento = texto.substring(j, j+i-1);
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
		return (new StringBuilder(texto)).reverse().toString().equals(texto);
	}
}
