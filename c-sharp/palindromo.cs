using System;
using System.IO;

class Palindromo {
	public static void Main() {
		string texto = (new StreamReader(txt)).ReadLine("../string.txt");
		string palindromo = "";
		for(int i = 2; i < texto.Length; i++) {
			for(int j = 0; j < texto.Length; j++) {
				if(j + i <= texto.Length) {
					string fragmento = texto.Substring(j, i);
					if(CheckPalindromo(fragmento) && fragmento.Length > palindromo.Length) {
						palindromo = fragmento;
					}
				}
			}
		}
		Console.WriteLine(palindromo);
	}

	public static bool CheckPalindromo(String txt) {
		string mitadTexto = txt.Substring(0, txt.Length / 2);
		char[] arr = txt.ToCharArray();

		Array.Reverse(arr);
		string reversa = new string(arr);

		string mitadReversa = reversa.Substring(0, reversa.Length / 2);
		return mitadTexto.Equals(mitadReversa);
	}
}