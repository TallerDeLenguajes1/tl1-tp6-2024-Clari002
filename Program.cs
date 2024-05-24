// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//punto 1

int num;
Console.WriteLine("-----------INVERTIR UN NUMERO--------------");
Console.WriteLine("Ingrese un numero: ");
if (!int.TryParse(Console.ReadLine(),out num))
{
    Console.WriteLine("El valor que ha ingresado no es un numero");
}else{
    int numInvertido=0;
    Console.WriteLine("Valor de num: "+num);

    while (num>0)
    {
        numInvertido=numInvertido * 10 + num % 10;
        num = num/10;
    }
    Console.WriteLine("Valor invertido: "+ numInvertido);
}

//punto 4
Console.WriteLine();
Console.WriteLine("---------------TRABAJANDO CON STRING------------------");
Console.WriteLine("Ingresar un texto: ");
string texto = Console.ReadLine();

int longitud = texto.Length;
Console.WriteLine("La longitud de la cadena de texto es: "+longitud);

Console.WriteLine("Ingresar otro texto: ");
string texto2 = Console.ReadLine();
string textoConcatenado = texto + texto2;
Console.WriteLine("Cadenas concatenadas: "+textoConcatenado);

Console.WriteLine("Ingresar el indice de inicio para la subcadena (primer texto): ");
int indiceInicio = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar la longitud de la subcadena:");
int longitudSubcadena = int.Parse(Console.ReadLine());
string subcadena = texto.Substring(indiceInicio, longitudSubcadena);
Console.WriteLine("La subcadena extraída es: " + subcadena);

//calculadora
Console.WriteLine("------------CALCULADORA--------------");
int n1, n2;
Console.WriteLine("Ingrese primer numero: ");
if (!int.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("El valor que ha ingresado no es un numero");
    return;
}else{
    Console.WriteLine("Ingrese segundo numero: ");
    if (!int.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("El valor que ha ingresado no es un numero");   
        return;
    }else{
        int valor;
        do{
        Console.WriteLine("-------CALCULADORA-------");
        Console.WriteLine("(1)Sumar");
        Console.WriteLine("(2)Restar");
        Console.WriteLine("(3)Multiplicar");
        Console.WriteLine("(4)Division");
        Console.WriteLine("(0)Salir");
        Console.WriteLine("Ingresar valor: ");
        if (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("El valor que ha ingresado no es un numero");   
            return;
        }else{

            switch (valor)
            {
                case 1:
                int suma;
                suma = n1+n2;
                string cadenaSuma = suma.ToString();
                Console.WriteLine("La suma de "+n1+" y de "+n2+" es igual a: "+ cadenaSuma);
                break;
                case 2:
                int resta;
                resta=n1-n2;
                string cadenaResta = resta.ToString();
                Console.WriteLine("La resta de "+n1+" y de "+n2+" es igual a: "+ cadenaResta);
                break;
                case 3:
                int producto;
                producto=n1*n2;
                string cadenaProd = producto.ToString();
                Console.WriteLine("El producto de "+n1+" y de "+n2+" es igual a: "+ cadenaProd);
                break;
                case 4:
                int division;
                if (n2!=0)
                {
                    division=n1/n2;
                    string cadenaDiv = division.ToString();
                    Console.WriteLine("La division de "+n1+" y de "+n2+" es igual a: "+ cadenaDiv);
                }
                break;
                default:
                break;
            }
        }
        }while(valor!=0);
    }
        
}


Console.WriteLine("Recorrer la cadena con foreach");
foreach (char caracter in texto)
{
    Console.WriteLine(caracter);
}
Console.WriteLine("Ingresar la palabra a buscar en la cadena:");
string palabraBuscada = Console.ReadLine();
if (texto.Contains(palabraBuscada))
{
    Console.WriteLine("La palabra "+palabraBuscada+" se encuentra en el texto");
}else{
    Console.WriteLine("No se encuentra la palabra "+palabraBuscada+" en el texto");

}

string textoMay = texto.ToUpper();
string textoMin = texto.ToLower();
Console.WriteLine("El texto en mayusculas: "+ textoMay);
Console.WriteLine("El texto en minusculas: "+ textoMin);


Console.WriteLine("Ingrese una cadena separada por caracteres:");
string cadenaSeparada = Console.ReadLine();
string[] partes = cadenaSeparada.Split(',');
Console.WriteLine("Resultados:");
foreach (string parte in partes)
{
Console.WriteLine(parte);
}

Console.WriteLine("Ingresar una ecuacion que incluya(+,-,*,/) por ejemplo: 582+2 o 4/2 ");
string ecuacion = Console.ReadLine();
if (ecuacion.Contains("+"))
{
    string [] numeros = ecuacion.Split('+');
    double resultado = double.Parse(numeros[0])+double.Parse(numeros[1]);
    Console.WriteLine(ecuacion + "=" + resultado);
}
if (ecuacion.Contains("-"))
{
    string [] numeros = ecuacion.Split('-');
    double resultado = double.Parse(numeros[0])-double.Parse(numeros[1]);
    Console.WriteLine(ecuacion+"="+ resultado);
}
if (ecuacion.Contains("*"))
{
    string [] numeros = ecuacion.Split('*');
    double resultado = double.Parse(numeros[0])*double.Parse(numeros[1]);
    Console.WriteLine(ecuacion + "=" + resultado);
}
if (ecuacion.Contains("/"))
{
    string [] numeros = ecuacion.Split('/');
    double resultado = double.Parse(numeros[0])/double.Parse(numeros[1]);
    Console.WriteLine(ecuacion+"="+ resultado);
}

//punto 5
Console.WriteLine("Ingrese una direccion: ");
string direccionTexto = Console.ReadLine();
string inicioDireccion = "https://www.";
string finDireccion1 = ".com";
string finDireccion2 = ".ar";
if (direccionTexto.StartsWith(inicioDireccion) && (direccionTexto.EndsWith(finDireccion1)||direccionTexto.EndsWith(finDireccion2)))
{
    Console.WriteLine("La direccion proporcionada es valida");
}else{
    Console.WriteLine("La direccion proporcionada no es valida");
}

Console.WriteLine("Ingrese un mail");
string emailTexto = Console.ReadLine();
if (emailTexto.Contains("@"))
{
    if (emailTexto.EndsWith(".com")||emailTexto.EndsWith(".net"))
    {
        Console.WriteLine("Email valido");
    }
}else{
    Console.WriteLine("Email no valido");
}


