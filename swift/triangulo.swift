import Foundation
func triangulo() {
    var triangulo = Array<Array<Int!>>()
    let archivo = "../triangle.txt".stringByExpandingTildeInPath
    let contenido = NSString(contentsOfFile: archivo, encoding: NSUTF8StringEncoding, error: nil) as! String
    let lineas = (contenido.componentsSeparatedByString("\n")).filter({ !$0.isEmpty })

    /* Obtener, Filtrar y Convertir */
    for i in 0..<lineas.count {
        triangulo.append((lineas[i].componentsSeparatedByString(" ")).map { $0.toInt() as Int!})
    }
    for i in reverse(0...(triangulo.count - 2)) {
        for j in 0...i {
            triangulo[i][j] = triangulo[i][j] + max(triangulo[i+1][j], triangulo[i+1][j+1]);
        }
    }
    print(triangulo[0][0])
}

triangulo()