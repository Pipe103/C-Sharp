namespace ConsoleApp1;

class Program
{
        static void Main(string[] args) 
    {
        //RETO DE TIPOS DE DATOS  
        int age =25;
        decimal height = 1.75m;
        bool is_student = true;
        string name = "ana";
        char grade = 'A';
        Console.WriteLine($"     RETOS TIPOS DE DATOS \n el entero tiene un valor de : {age}\n el decimal tiene un valor de : {height}\n el booleano es : {is_student}\n el nombre es : {name}\n el caracter es : {grade}");
        
    //RETO DE OPERADORES
        int width = 7;
        // el cambio de la variable height a theigth se debe ya que hay 2 variables iguales 
        int Theight = 5;
        int area = width * Theight;
        int perimeter = 2*width + 2*Theight;
        width += 3;
        Theight -= 2;
        Console.WriteLine($"     RETOS DE OPERADORES\n valor final de width : {width}\n valor final de height : {Theight}\n el area tiene un valor de : {area}\n el perimetro tiene un valor de : {perimeter}");
    }
}