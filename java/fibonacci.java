import java.lang.*;
import java.util.*;

public class fibonacci {
	public static void main(String[] args) {
		int a = 1, b = 1, temp = 0;

		while(true) {
			temp = a; a = b; b = temp + b;
			if(factores(a) >= 1000) {
				System.out.println(a);
				return;
			}
		}
	}

	public static int factores(int numero) {
		ArrayList<Integer> divisores = new ArrayList<Integer>();
		for(int i = 1; i <= Math.sqrt(numero); ++i) {
			if(numero % i == 0) {
				divisores.add(i);
				if(i != numero/i) {
					divisores.add(numero/i);
				}
			}
		}
		return divisores.size();
	}
}