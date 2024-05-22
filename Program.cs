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

//punto 3
Console.WriteLine("-----------------CalculadoraV2-----------------");
Console.WriteLine("Ingrese un numero: ");
if (!double.TryParse(Console.ReadLine(), out double N))
{
    Console.WriteLine("El N que ha ingresado no es un numero");
}else{
    int respuesta;
    do
    {
        double absoluto = Math.Abs(N);
        double cuadrado = Math.Pow(N, 2);
        double raizCuad = Math.Sqrt(N);
        double funcionSeno = Math.Sin(N);
        double funcionCos = Math.Cos(N);
        double parteEntera = Math.Truncate(N);
        Console.WriteLine("................RESULTADOS................");
        Console.WriteLine("Valor Absoluto: "+absoluto);
        Console.WriteLine("Cuadrado: "+cuadrado);
        Console.WriteLine("Raiz Cuadrada: "+raizCuad);
        Console.WriteLine("Sen: "+funcionSeno);
        Console.WriteLine("Cos: "+funcionCos);
        Console.WriteLine("Parte Entera: "+ parteEntera);

        Console.WriteLine("¿Desea ingresar otro num? 1(SI) 0(NO): ");
        if (!int.TryParse(Console.ReadLine(), out respuesta))
        {
            Console.WriteLine("Valor incorrecto");
        }else{
            if (respuesta==1)
            {
                Console.WriteLine("Ingrese un numero: ");
                    if (!double.TryParse(Console.ReadLine(), out N))
                    {
                        Console.WriteLine("El N que ha ingresado no es un numero");
                    }
            }   
        }      
    } while (respuesta!=0);
}

Console.WriteLine();
Console.WriteLine("---------------Max y Min-------------");
Console.WriteLine("Ingrese un numero: ");
if (!double.TryParse(Console.ReadLine(), out double num1))
{
  Console.WriteLine("Valor incorrecto");  
}else{
    Console.WriteLine("Ingrese otro numero: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Valor incorrecto");     
    }else{
        double maximo=Math.Max(num1,num2);
        double minimo=Math.Min(num1,num2);
        Console.WriteLine("El maximo es: "+maximo);
        Console.WriteLine("El minimo es: "+minimo);
    }
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

