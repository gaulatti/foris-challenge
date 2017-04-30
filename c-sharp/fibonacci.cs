using System;
using System.Collections;

class Fibonacci() {
	public static void Main() {
		Int64 a = 1, b = 1;
		while (true)
		{
			Int64 temp = a; a = b; b = temp + b;
			if(factores(a) >= 1000) {
				Console.WriteLine(a);
				return ;
			}
		}
	}

	public static int factores(Int64 numero) {
		ArrayList divisores = new ArrayList();
		int max = (int)Math.Sqrt(numero);
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