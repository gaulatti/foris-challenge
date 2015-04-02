def fibonacci()
	a = b = 1;
	while true
		temp = a; a = b; b = temp + b
		if factors(a) >= 1000
			puts a
			return
		end
	end
end

def factors(num)
	divisores = []
	n = 1
	while n <= num ** 0.5
		if num.modulo(n) == 0
			divisores << divisores << num / n unless num / n == n
		end
		n += 1
	end
	return divisores.length
end

fibonacci()