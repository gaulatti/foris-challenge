import Foundation
extension String {
    subscript (r: Range<Int>) -> String {
        get {
            let startIndex = advance(self.startIndex, r.startIndex)
            let endIndex = advance(startIndex, r.endIndex - r.startIndex)

            return self[Range(start: startIndex, end: endIndex)]
        }
    }
}
func palindromo() {
    let file = "../string.txt".stringByExpandingTildeInPath
    let str = NSString(contentsOfFile: file, encoding: NSUTF8StringEncoding, error: nil) as! String
    let length = count(str)
    var palindromoActual: String = ""
    for i in 2...length {
        for j in 0...length {
            if (j + i) <= length {
                var fragmento = str[i..<(i+j)]
                if(palindromo(fragmento)) {
                    println(fragmento)
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