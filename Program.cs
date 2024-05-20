// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//punto 1
int num;
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

//punto 2
int n1, n2;
Console.WriteLine("Ingrese primer numero: ");
if (!int.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("El valor que ha ingresado no es un numero");
}else{
    Console.WriteLine("Ingrese segundo numero: ");
    if (!int.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("El valor que ha ingresado no es un numero");   
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
        }else{

            switch (valor)
            {
                case 1:
                int suma;
                suma = n1+n2;
                Console.WriteLine("Suma: "+ suma);
                break;
                case 2:
                int resta;
                resta=n1-n2;
                Console.WriteLine("Resta: "+ resta);
                break;
                case 3:
                int producto;
                producto=n1*n2;
                Console.WriteLine("Multiplicacion: "+ producto);
                break;
                case 4:
                int division;
                if (n2!=0)
                {
                    division=n1/n2;
                    Console.WriteLine("Division: "+ division);
                }
                break;
                default:
                break;
            }
        }
        }while(valor!=0);
    }
        
}

