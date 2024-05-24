¿String es un tipo por valor o un tipo por referencia? Es un tipo por referencia

¿Que secuencias de escape tiene el tipo string?
¿Que secuencias de escape tiene el tipo string El tipo string en c# admite varias secuencias de escape, que son caracteres especiales utilizados para representar caracteres no imprimibles o caracteres que tienen un significado especial en una cadena.Secuencias de escape mas comunes: ": Comilla doble. ': Comilla simple. \: Barra invertida. \0: Caracter nulo. \a: Caracter de alarma (bip). \b: Retroceso. \f: Salto de pagina. \n: Salto de linea. \r: Retorno de carro. \t: Tabulacion hotizontal. \v: Tabulacion vertical.

¿Que sucede cuando utiliza el caracter @ y $ antes de una cadena de texto?  La notacion @ antes de una cadena de texto permite que la cadena se interprete literalmente, lo que significa que los caracteres de escape (como \n o \t) no seran procesados y se consideraran como caracteres normales dentro de la cadena. Esto puede ser util cuando se trabaja con cadenas de texto que contienen rutas de archivo, expresiones regulares u otros casos en los que se desea evitar las necesidad de escribir dobles barras invertidas () \ para representar una barra invertida en la cadena.
El caracter $ antes de una cadena de texto en c# indica que la cadena es una cadena de texto interpolada, tambien conocida como interpolaacion de cadenas. La interpolacion de cadenas permite incrustar expresiones dentro de una cadena utilizando la sintaxis '${expression}'. Las expresiones se evaluan en tiempo de ejecucion y se sustituyen por su valor correspondiente dentro de la cadena.

EJERCICIO 5 (Expresiones Regulares: son conjuntos de patrones utilizados para buscar y manipular cadenas de texto de manera eficiente)
-¿Funcionan unicamente en C#? No, tambien funcionan en otros lenguajes de programacion como: Java, Python, JavaScript, etc.
-¿En que casos le parecen utiles? Enuncie al menos 3. Validacion de formatos de entrada, Extraccion de informacion, Reemplazo de texto.
-¿Como se hace uso de estas en C#? se hace uso utilizando la clase Regex del espacio de nombres System.Text.RegularExpressions.
