//1)      Pedir al usuario la longitud de un vector
Console.Write("Ingrese la longitud del vector: ");
int tamanio = int.Parse(Console.ReadLine());

//2)      Crear el vector del tamaño ingresado.
int[] vector = new int[tamanio];
int[] vectorInv = new int[tamanio];
//3)      Llenar el mismo con datos aleatorios
Random r = new Random();
for (int i=0; i<tamanio; i++)
{
    vector[i] = r.Next(1, 100);
}

//4)      Mostrar el vector por pantalla
Console.Write("Mostrando datos del vector..! \n");
foreach (int aux in vector)
{
    Console.Write(aux + "   ");
}

//5)      Invertir el vector, de manera que el
//primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo,
//el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector
//es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido,
//el vector debe quedar así: 50, 40, 30, 20, 10.
//Se debe usar solo lo visto en clase hasta
//ahora y no los métodos que trae C# para estas cuestiones.
//Console.Write("Invirtiendo datos del vector..! \n");
int contador = 0;
for (int i = tamanio - 1; i >= 0; i--)
{
    vectorInv[contador] = vector[i];
    contador++;
}

//6)      Mostrar el vector nuevamente.
Console.Write("\nMostrando datos del vector Invertido final..! \n");
foreach (int j in vectorInv)
{
    Console.Write(j + "   ");
}
    

