def fibonacci()
  a = b = 1;
  while true
    a, b = b, a + b
    return a if factors(a) >= 1000
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

puts fibonacci()
