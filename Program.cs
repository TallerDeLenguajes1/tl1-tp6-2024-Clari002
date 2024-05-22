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
string s = "245";
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




