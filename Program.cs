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
int op;
int control;
do
{
    Console.WriteLine("Seleccione la operacion que desea realizar\n");
    Console.WriteLine("[1]. Sumar\n");
    Console.WriteLine("[2]. Restar\n");
    Console.WriteLine("[3]. Multiplicar\n");
    Console.WriteLine("[4]. Dividir\n");
    string operacion = Console.ReadLine();
    if (int.TryParse(operacion, out op) && 1<=op && op<=4)
    {
        float num1;
        float num2;
        string nro1;
        string nro2;
        do
        {
            Console.WriteLine("Ingrese el primer numero: \n");
            nro1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: \n");
            nro2 = Console.ReadLine();
        } while (!float.TryParse(nro1, out num1) || !float.TryParse(nro2, out num2));
        float resul = 0;
        switch (op)
        {
            case 1:
                resul = num1 + num2;
                break;
            case 2:
                resul = num1 - num2;
                break;
            case 3:
                resul = num1*num2;
                break;
            case 4:
                resul = num1/num2;
                break;
        }
        Console.WriteLine($"El resultado es: {resul}");
    } 
    Console.WriteLine("Desea seguir operando?\n");
    Console.WriteLine("[1]. Si\n");
    Console.WriteLine("[0]. No\n");
    string controla = Console.ReadLine();
    if (!int.TryParse(controla, out control))
    {
        control = 1;
    }
} while (control != 0);





