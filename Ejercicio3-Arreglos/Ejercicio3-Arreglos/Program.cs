int[] numeros = new int[10];
double SumaElementos = 0;
int mayorNumero = 0;
int menorNumero = 999999;

Console.WriteLine("Ingrese 10 numeros positivos!!");
for (int i = 0; i < numeros.Length; i++)
{
    //1) Pida 10 números al usuario.
    Console.Write($"Ingrese el numero {i} -> ");
    numeros[i] = Int32.Parse(Console.ReadLine());
    //2) Obtener la suma de todos los números ingresados.
    SumaElementos = SumaElementos + numeros[i];
    //3) Obtener cual es el mayor de todos los números.
    if (mayorNumero < numeros[i])
    {
        mayorNumero = numeros[i];
    }
    //4) Obtener cual es el menor de todos los números.
    if (menorNumero > numeros[i])
    {
        menorNumero = numeros[i];
    }
}
Console.WriteLine("Suma de todos los numeros ingresados son: " + SumaElementos);
Console.WriteLine("El Mayor numero es: " + mayorNumero);
Console.WriteLine("El Menor numero es: " + menorNumero);
//5) Obtener el promedio de todos los números.
double promedio = (Math.Abs(SumaElementos) / numeros.Length);
Console.Write($"El promedio es: {promedio}");
//6) Mostrar todos los números ingresados por pantalla.
Console.WriteLine("\nLos numeros Ingresados son: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + "\t");
}