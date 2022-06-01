///*
//    EJERCICIO
//    Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:
//    Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla.
//    1) Cartón de 3 filas por 9 columnas.
//    2) El cartón debe tener 15 números y 12 espacios en blanco.
//    3) Cada fila debe tener 5 números.
//    4) Cada columna debe tener 1 o 2 números.
//    5) Ningún número puede repetirse.
//    6) La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la
//       tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene
//       del 80 al 90.
//    7) Mostrar el carton por pantalla.
//*/

int[,] bingo = new int[3, 9];//bingo fila 3 col 9
Random r = new Random();
int maxColumna = 0;
int numeroGenerado;
int[] limiColumna = new int[9];
int total = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine("\t\t\t\t [----JUEGO DEL BINGO---] \n");
    Console.Write(" --------------------------------------------------------------------------------");
    Console.Write(" \n --------------------------------------------------------------------------------");

    Console.Write("\t\t\t\n¿Cuantas tableros desea generar?: ");
    int cantidad = int.Parse(Console.ReadLine());
    for (int k = 0; k < cantidad; k++)
    {
        //generar numero de columnas
        while (total == 0 || total != 16)
        {
            total = 0;
            for (int i = 0; i < 9; i++)
            {
                limiColumna[i] = r.Next(1, 3);
                total = total + limiColumna[i];
            }
        }

        // generar numeros respecto a cada columna.
        for (int columna = 0; columna < 9; columna++)
        {
            for (int fila = 0; fila < 3; fila++)
            {
                if ((limiColumna[columna] - 1) >= maxColumna)
                {
                    numeroGenerado = r.Next(columna * 10, (columna + 1) * 10);
                    while (numeroGenerado == bingo[0, columna] ||
                           numeroGenerado == bingo[1, columna] ||
                           numeroGenerado == bingo[2, columna])
                    {
                        numeroGenerado = r.Next(columna * 10, (columna + 1) * 10);
                    }
                    bingo[fila, columna] = numeroGenerado;
                }
                maxColumna++;
            }
            maxColumna = 0;
        }

        //mostrar la matriz bingo
        for (int i = 0; i < 3; i++)
        {
            Console.Write("\n||\t");
            for (int j = 0; j < 9; j++)
            {
                if (bingo[i, j] != 0)
                {
                    Console.Write($"{bingo[i, j]} \t");
                }
                else
                {
                    Console.Write("\t");
                }

            }
            Console.Write("||\n");
        }
        Console.Write("\n _______________________________________________________________________________");
    }


    Console.Write("\t\t\t\n¿Desea generar mas tarjetas de bingo? ");
    Console.Write("\t\t\t\n S/N:  ");
    String opc = Console.ReadLine();
    if (opc == "S")
    {
        continue;
    }
    else
    {
        break;
    }
}


