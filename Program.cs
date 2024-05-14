// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

Console.WriteLine("\n------Ejercicio 1------\n");
Console.WriteLine("Ingrese un numero: ");
string cadena = Console.ReadLine();
int num;
int resto;
int nroInv = 0;
if (int.TryParse(cadena, out num))
{
    if (num > 0)
    {
        while (num != 0)
        {
            resto = num%10;
            num = num/10;
            nroInv = nroInv*10 + resto; 
        }
    } else
    {
        Console.WriteLine("El numero ingresado no es mayor a 0\n");
    }
    Console.WriteLine("El numero invertido es: "+nroInv);
} else
{
    Console.WriteLine("No se ha ingresado un numero\n");
}

Console.WriteLine("\n------Ejercicio 2------\n");




