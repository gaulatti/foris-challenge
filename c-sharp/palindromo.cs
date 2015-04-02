using System;
using System.IO;

class Palindromo {
	public static void Main() {
		string texto = LeerArchivo("../string.txt");
		string palindromo = "";

		/* Recorriendo el String */
		for(int i = 2; i < texto.Length; i++) {
			for(int j = 0; j < texto.Length; j++) {

				/* Restricciones. Siempre son buenas para prevenir excepciones */
				if(j + i <= texto.Length) {

					/* Obtener Fragmento */
					string fragmento = texto.Substring(j, i);

					/* Chequear el Mayor Palíndromo */
					if(CheckPalindromo(fragmento) && fragmento.Length > palindromo.Length) {
						palindromo = fragmento;
					}
				}
			}	
		}

		/* Y por lo tanto? */
		Console.WriteLine(palindromo);
	}

	public static string LeerArchivo(String txt) {
		StreamReader r = new StreamReader(txt);
		return r.ReadLine();
	}

	public static bool CheckPalindromo(String txt) {
		/* Obtener Mitad Original */
		string mitadTexto = txt.Substring(0, txt.Length / 2);
		char[] arr = txt.ToCharArray();

        /* Flip! Media Vuelta! */
		Array.Reverse(arr);
		string reversa = new string(arr);

        /* Obtener Mitad Reversa y Comparar con la Mitad Original*/
		string mitadReversa = reversa.Substring(0, reversa.Length / 2);
		return mitadTexto.Equals(mitadReversa);
	}
}