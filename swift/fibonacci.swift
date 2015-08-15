import Darwin

func fibonacci() {
    var a: Double = 1; var b: Double = 1; var temp: Double;
    var finish :Bool = false
    while(!finish) {
        temp = a; a = b; b += temp;
        if(factores(a) >= 1000) {
            print(Int(a))
            finish = true
        }
    }
}

func factores(num: Double) -> Int {
    var divisores = [Double]()
    var n: Double = 1
    while(n <= sqrt(num)) {
        if(num % n == 0) {
            divisores.append(n)
            if(n != num/n) {
                divisores.append(num/n)
            }
        }
        n++
    }
    return divisores.count
}

fibonacci()