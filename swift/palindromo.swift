import Foundation
func palindromo() {
    let file = "../string.txt".stringByExpandingTildeInPath
    let str = NSString(contentsOfFile: file, encoding: NSUTF8StringEncoding, error: nil) as! String
    let length = count(str)
    var palindromoActual: String = ""
    for i in 0...length {
        for j in 2...length {
            if ((j + i) <= length) {
                var fragmento = str[advance(str.startIndex, i)..<advance(str.startIndex, i + j)]
                if(palindromo(fragmento) && count(fragmento) >= count(palindromoActual)) {
                    palindromoActual = fragmento
                }
            }
        }
    }
    println(palindromoActual)
}

func palindromo(str:String) -> Bool {
    var buffer = ""
    for character in str { buffer.insert(character, atIndex: buffer.startIndex) }
    return buffer == str
}

palindromo()