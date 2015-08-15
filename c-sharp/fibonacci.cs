using System;
using System.Collections;

class Fibonacci() {
	public static void Main() {
		Int64 a = 1, b = 1;
		while (true)
		{
			/* Fibonacci */
			Int64 temp = a; a = b; b = temp + b;
			if(Factores(a) >= 1000) {
				Console.WriteLine(a);
				return ;
			}
		}
	}

	public static int Factores(Int64 numero) {
		/* En algún lugar debo alojar los divisores */
		ArrayList divisores = new ArrayList();

		/* Desde el 1 hasta la Raíz Cuadrada */
		int max = (int)Math.Sqrt(numero);

		/* Go! Go! Go! */
		for(int factor = 1; factor <= max; ++factor) {
			if(numero % factor == 0) {
				divisores.Add(factor);
				if(factor != numero/factor) {
					divisores.Add(numero/factor);
				}
			}
		}
		return divisores.Count;
	}
}