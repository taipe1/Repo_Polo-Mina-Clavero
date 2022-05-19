//1) Generar un número secreto aleatorio con la siguiente instruccion:Genera un numero entero aleatorio de 1 a 20
//int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int contador = 0;//contador inicializado en cero
Random rand = new Random(DateTime.Now.Millisecond);
int numeroSecreto = rand.Next(1, 21);
int numeroIngresado = 0;
Console.WriteLine("el numero secreto es: " + numeroSecreto);
//bucle while infinito
while (true)
{
    contador = contador + 1;//contador incrementando en 1
    Console.WriteLine("Ingrese un numero a buscar: ");
    //Pedir al usuario que ingrese un número y que intente adivinar el número que eligió la computadora.
    numeroIngresado = Convert.ToInt32(Console.ReadLine());
    //Si el número ingresado coincide con el número secreto, sacar el siguiente mensaje:
    if (numeroIngresado == numeroSecreto)
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era:{numeroSecreto}");
        Console.WriteLine($"\nLo has logrado en {contador} intentos!!");
        break;
    }
    //Si el numero ingresado es menor al número secreto, avisarle que es muy chico, y que intente de nuevo
    else if (numeroIngresado < numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es muy chico, intente de nuevo!!!");
    }
    else
    {
        Console.WriteLine("El numero ingresado es muy grande, intente de nuevo!!!");
    }
}
