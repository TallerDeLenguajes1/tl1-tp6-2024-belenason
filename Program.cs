// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

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
int op;
int control;
do
{
    Console.WriteLine("Seleccione la operacion que desea realizar\n");
    Console.WriteLine("[1]. Valor absoluto\n");
    Console.WriteLine("[2]. Cuadrado\n");
    Console.WriteLine("[3]. Raiz cuadrada\n");
    Console.WriteLine("[4]. Seno\n");
    Console.WriteLine("[5]. Coseno\n");
    Console.WriteLine("[6]. Parte entera\n");
    string operacion = Console.ReadLine();
    if (int.TryParse(operacion, out op) && 1<=op && op<=6)
    {
        float numm;
        string nro;
        do
        {
            Console.WriteLine("Ingrese un numero: \n");
            nro = Console.ReadLine();
        } while (!float.TryParse(nro, out numm));
        double resul = 0;
        switch (op)
        {
            case 1:
                resul = Math.Abs(numm);
                break;
            case 2:
                resul = numm*numm;
                break;
            case 3:
                resul = Math.Sqrt(numm);
                break;
            case 4:
                resul = Math.Sin(numm);
                break;
            case 5:
                resul = Math.Cos(numm);
                break;
            case 6:
                resul = (int)numm;
                break;

        }
        Console.WriteLine($"El resultado es: {resul}");
    } 
    Console.WriteLine("\nDesea seguir operando?\n");
    Console.WriteLine("[1]. Si\n");
    Console.WriteLine("[0]. No\n");
    string controla = Console.ReadLine();
    if (!int.TryParse(controla, out control))
    {
        control = 1;
    }
} while (control != 0);
float c;
string n1;
float d;
string n2;
Console.WriteLine("A continuacion ingrese dos numeros\n");
do
{
    Console.WriteLine("Primer numero: ");
    n1 = Console.ReadLine();
    Console.WriteLine("\nSegundo numero: ");
    n2 = Console.ReadLine(); 
} while (!float.TryParse(n1, out c) || !float.TryParse(n2, out d));
if (c > d)
{
    Console.WriteLine($"\nEl maximo entre los dos numeros es: {c}\n");
    Console.WriteLine($"El minimo entre los dos numeros es: {d}\n");
} else if (d > c)
{
    Console.WriteLine($"\nEl maximo entre los dos numeros es: {d}\n");
    Console.WriteLine($"El minimo entre los dos numeros es: {c}\n");
} else
{
    Console.WriteLine("Ambos numeros son iguales\n");
}



