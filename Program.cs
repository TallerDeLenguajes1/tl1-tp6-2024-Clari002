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

//punto 4
