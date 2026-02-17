namespace tallerControlCondicional;
//TALLER DE CONTROL CONDICIONAL
class Program
{
    static void Main(string[] args)
    {
        int CheckNumber = 8;
        if (CheckNumber>0){
            Console.WriteLine("el numeroes positivo");
        }else if (CheckNumber < 0)
        {
            Console.WriteLine("el numero es negativo");
        }
        else
        {
         Console.WriteLine("el numero es 0");
        }
    }
}
