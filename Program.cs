// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

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

Console.WriteLine("\n------Ejercicio 4------\n");
Console.WriteLine("Ingrese una cadena de texto\n");
string cadena1 = Console.ReadLine();
int longi = cadena1.Length;
Console.WriteLine($"La cadena es \"{cadena1}\" y tiene una longitud de {longi}");

Console.WriteLine("Ingrese una nueva cadena de texto\n");
string cadena2 = Console.ReadLine();
string concantenado = string.Concat(cadena1, " ", cadena2);
Console.WriteLine($"La cadena concatenada es \"{concantenado}\"\n");

Console.WriteLine("Extraemos una subcadena de la primer cadena ingresada\n");
string ini;
string longit;
int inicio;
int longg;
do
{
    Console.WriteLine("Ingrese a partir de que posicion de la cadena principal quiere extraer la subcadena\n");
    ini = Console.ReadLine();
    Console.WriteLine("Ingrese la longitud que desea que tenga la subcadena\n");
    longit = Console.ReadLine();
} while (!int.TryParse(ini, out inicio) || !int.TryParse(longit, out longg));
string subCad = cadena1.Substring(inicio-1, longg);
Console.WriteLine($"La subcadena resultante es \"{subCad}\"\n");

string nro1;
float num1;
string nro2;
float num2;
do
{
    Console.WriteLine("Ingrese un numero");
    nro1 = Console.ReadLine();
    Console.WriteLine("Ingrese otro numero");
    nro2 = Console.ReadLine();
} while (!float.TryParse(nro1, out num1) || !float.TryParse(nro2, out num2));
Console.WriteLine("La suma de "+num1.ToString()+" y "+num2.ToString()+" es igual a: "+(num1 + num2).ToString());

Console.WriteLine("La primer cadena recorrida con un foreach queda: \n");
foreach (char caracter in cadena1)
{
    Console.WriteLine(caracter);
}

Console.WriteLine("\nIngrese la palabra que desea buscar en la cadena: ");
string Abuscar = Console.ReadLine();
if (cadena1.Contains(Abuscar))
{
    int start = 0;
    int at = 0;
    int end = cadena1.Length;
    int c = 0;
    Console.WriteLine("La palabra ingresada aparece en la cadena en la/s posicion/es:");
    while ((start <= end) && (at > -1))
    {
        c = end - start;
        at = cadena1.IndexOf(Abuscar, start, c);
        if (at == -1) break;
        Console.WriteLine(at+1);
        start = at+1;
    }
} else
{
    Console.WriteLine("La palabra ingresada no aparece en la cadena\n");
}

Console.WriteLine($"\nLa cadena en mayusculas es \"{cadena1.ToUpper()}\"");
Console.WriteLine($"La cadena en minusculas es \"{cadena1.ToLower()}\"");

Console.WriteLine("Ingrese cual desea que sea el separador de la cadena\n");
string separador;
do
{
    separador = Console.ReadLine();
    if(!cadena1.Contains(separador))
    {
        Console.WriteLine("El caracter ingresado no se encuentra en la cadena, seleccione otro separador");
    }
} while (!cadena1.Contains(separador));
string [] palabras = cadena1.Split(separador);
foreach (string parte in palabras)
{
    Console.WriteLine(parte);
}

Console.WriteLine("\nIngrese la operacion a realizar\n");
string op = Console.ReadLine();
string [] operandos;
float ops1;
float ops2;
float resul = 0;
int control = 0;
if (op.Contains('+'))
{
    operandos = op.Split('+');
    if (float.TryParse(operandos[0].Trim(), out ops1) && float.TryParse(operandos[1].Trim(), out ops2))
    {
        resul = ops1 + ops2;
    } else
    {
      control = 1; 
    }
} else if (op.Contains('-'))
{
    operandos = op.Split('-');
    if (float.TryParse(operandos[0].Trim(), out ops1) && float.TryParse(operandos[1].Trim(), out ops2))
    {
        resul = ops1 - ops2;
    } else
    {
      control = 1; 
    }
} else if (op.Contains('/'))
{
    operandos = op.Split('/');
    if (float.TryParse(operandos[0].Trim(), out ops1) && float.TryParse(operandos[1].Trim(), out ops2))
    {
        resul = ops1/ops2;
    } else
    {
      control = 1;  
    }
} else if (op.Contains('*'))
{
    operandos = op.Split('*');
    if (float.TryParse(operandos[0].Trim(), out ops1) && float.TryParse(operandos[1].Trim(), out ops2))
    {
        resul = ops1*ops2;
    } else
    {
      control = 1; 
    }
} else
{
    control = 1;
}
if (control == 0 || resul != 0)
{
    Console.WriteLine($"El resultado de la operacion {op} es {resul}\n");
} else
{
    Console.WriteLine("Error al intentar operar. Puede ser posible que no se haya identificado ninguna operacion o que se haya ingresado un caracter con el cual no se sabe operar.\n");
}

Console.WriteLine("\n------Ejercicio 5------\n");
Console.WriteLine("\nIngrese una dirección web: ");
string direcWebUsu = Console.ReadLine();
string valida = @"^(https?://|www\.)[\w-]+\.[a-z]+(/[^\s]*)?$"; //El ^ se usa para indicar que empieza la cadena y el $ para indicar que termina, (https?://|www\.) se fija que la cadena que comience con “http://”, “https://” o “www.”, [\w-]+ busca uno o más caracteres alfanuméricos o guiones, \. busca un punto literal (se usa la barra invertida para escaparlo), [a-z]+ busca uno o más caracteres en minúscula (representando el dominio), por último, (/[^\s]*)? busca una ruta opcional después del dominio, la cual comienza con una barra diagonal y puede contener cualquier carácter excepto espacios en blanco (hay que recordar que ^ significa negación).
if (Regex.IsMatch(direcWebUsu, valida, RegexOptions.IgnoreCase))
{
    Console.WriteLine("\nLa direccion web ingresada es valida.");
} else
{
    Console.WriteLine("\nLa direccion web ingresada NO es valida.");
}
Console.WriteLine("\nIngrese un mail: ");
string mailUsu = Console.ReadLine();
string valido = @"^[a-z0-9._-]+@[a-z0-9.-]+\.[a-zA-Z]{2,}(.[a-z])?$"; // {} se utilizan para indicar la cantidad de veces que un conjunto de caracteres debe aparecer, la coma indica que no hay un máximo, el conjunto de caracteres puede aparecer dos o más veces; (.[a-z])? es por si tienen un mail con .ar o lo correspondiente en otros paises
if (Regex.IsMatch(mailUsu, valido, RegexOptions.IgnoreCase))
{
    Console.WriteLine("\nEl mail ingresado es valido.");
} else
{
    Console.WriteLine("\nEl mail ingresado no es valido.");
}
















