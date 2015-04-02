#!/usr/bin python
def fibonacci():

	a = b = 1;
	while a > 0:
		temp = a; a = b; b = temp + b
		if factors(a) >= 1000:
			print a
			return

def factors(n):    
    return len(set(reduce(list.__add__, ([i, n//i] for i in range(1, int(n**0.5) + 1) if n % i == 0))))

fibonacci()