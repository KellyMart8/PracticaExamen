//Ciclo repetitivo While

int a = 3;

while (a < 10)
{
    Console.WriteLine("El valor es: " + (a++));
}

int b = 20;
while (b >= 9)
{
    Console.WriteLine("**El valor es " + b);
    b--;
}
Console.WriteLine("EL blucle (WHILE) ha terminado");


//Ciclo repetitivo DO-WHILE

int c = 15;

do
{
    Console.WriteLine("Valor actual: {0}", c);
} while (c < 10);

//En do -while, primero se ejecuta la accion y luego se valida;
//En WHILE primero se valida para luego ser ejecutado

double estatura; // altraMaxima = 1.75 ; la podemos poner con valor para mas adelante solo modificar en el valor de esta
do
{
    Console.WriteLine("Ingrese su estatura: ");
    estatura = double.Parse(Console.ReadLine());    // =Convert.ToDouble(Console.ReadLine())
    if (estatura > 1.75)
    {
        Console.WriteLine("Altura maxima es de 1.75m. ");
    }
} while (estatura > 1.75);   //Si se cumple, se ejecutará
                             //por lo tanto para validar, lo que va dentro del parentesis es lo que NO debe cumplirse

double nota;

do
{
    Console.WriteLine("Ingrese una nota:");
    nota = Convert.ToDouble(Console.ReadLine());

    if (nota < 0 || nota > 60)
    {
        Console.WriteLine("El rango de notas para ingrsar es de 0 - 60");
    }
} while (nota < 0 || nota > 60);

//ciclo*** FOR***

//Console.WriteLine("**********");
//for (int a = 0; a <= 10; a++)
//{
//    Console.WriteLine(a);
//}

//for (int a = 100; a > 10; a = a - 5)
//{
//    Console.WriteLine("El valor {0}", a);
//}

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Ingrese valor {0}", i);
    int valor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("El valor {0}", valor);
}

for (int y = 15; y <= 36; y++)
{
    Console.WriteLine("Valor actual {0}", y);
    if ((y % 7) == 0)
    {
        Console.WriteLine("{0} Es el primer multiplo de 7", y);
        break;
    }
}

