//Crear un programa que cumpla con los siguientes pasos

//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
int fila = 0;
int columna = 0;
double sumaColumnas = 0;

//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
Console.Write("Ingrese el numero de fila: ");
fila = Int32.Parse(Console.ReadLine());
Console.Write("Ingrese el numero de columna: ");
columna = Int32.Parse(Console.ReadLine());
int[,] numeros = new int[fila, columna];

//3) Declarar un vector de tipo double llamado promedios
double[] promedios = new double[columna];

//4) Recorrer la matriz para su carga con elementos de tipo int
for(int i = 0; i < fila; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.Write("Ingrese el numero " + (j+1)+ " : ");
        int auxiliar = Int32.Parse(Console.ReadLine());
        numeros[i, j] = auxiliar;
    }
}
//5) Recorrer la matriz para mostrar cada valor de la matriz;
Console.WriteLine("\Recorriendo la matriz......!");
for (int i = 0; i < fila; i++)
{
    Console.WriteLine("Mostrando los valores de la fila " + (i + 1));
    for (int j = 0; j < columna; j++)
    {
        Console.Write(numeros[i, j] + "  ");
    }
    Console.WriteLine("\n");
}
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
for (int i = 0; i < columna; i++)
{
    sumaColumnas = 0;
    for (int j = 0; j < fila; j++)
    {
        sumaColumnas = sumaColumnas +  numeros[j,i];
    }
    promedios[i] = sumaColumnas/fila;
}
//7) Mostrar los promedios recorriendo el vector promedios
Console.WriteLine("Mostrando los promedios....!");
for (int i = 0; i < columna; i++)
{
    Console.WriteLine("Promedio de la columna " + (i+1) + "-> " + (promedios[i]));
}










