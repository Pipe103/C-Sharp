//TALLER DE CONTROL CONDICIONAL
int CheckNumber;
Console.WriteLine("Positivo, Negativo o Igual a 0");
Console.WriteLine("ingresa tu numero");
CheckNumber = int.Parse(Console.ReadLine());
if (CheckNumber > 0)
{
    Console.WriteLine("el numeroes positivo");
}
else if (CheckNumber < 0)
{
    Console.WriteLine("el numero es negativo");
}
else
{
    Console.WriteLine("el numero es 0");
}
