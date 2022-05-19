// See https://aka.ms/new-console-template for more information
//Clase 5: Tarea - Ejercicio
//Escribir un programa que haga lo siguiente:
//1) Borrar la pantalla.
//2) Pedir el nombre de una persona.
//3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
//4) Preguntar si se quiere continuar.
//5) Si la respuesta es "S" repetir desde el punto 1.
//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".



char opc;
do
{
    Console.Clear();
    Console.WriteLine("\ningrese su nombre: ");
    string texto = Console.ReadLine();
    Console.WriteLine($"Hola, {texto}");
    Console.Write("Desea continuar? si='S' y no='N' -> ");
    opc = Console.ReadKey().KeyChar;
} while (opc == 'S');

if(opc == 'N')
{
    Console.WriteLine("\nPorgrama finalizado correctamente");
}
else
{
    Console.WriteLine("\nOpcion no valida");
}