
using Ejercicio13_Billetera.Modelo;

Billetera miBilletera = new();
PedirDatos(miBilletera);
Console.WriteLine($"Mi billetera tiene: {miBilletera.Total()} ");

Billetera otraBilletera = new();
PedirDatos(otraBilletera);
Console.WriteLine($"La otra billetera tiene: {otraBilletera.Total()} ");

Billetera billteraCombinada = new();
Billetera.Combinar(miBilletera, otraBilletera, billteraCombinada);

Console.WriteLine($"La billetera combinada tiene: {billteraCombinada.Total()} ");
Console.WriteLine($"Mi billetera ahora tiene {miBilletera.Total()}");
Console.WriteLine($"La otra billetera ahora tiene {otraBilletera.Total()}");

void PedirDatos(Billetera billetera)
{
    Console.WriteLine("Ingrese cuántos billetes de 10 soles tienes");
    billetera.BilletesDe10 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cuántos billetes de 20 soles tienes");
    billetera.BilletesDe20 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cuántos billetes de 50 tienes");
    billetera.BilletesDe50 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cuántos billetes de 100 soles queres?");
    billetera.BilletesDe100 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cuántos billetes de 200 soles queres?");
    billetera.BilletesDe200 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cuántos billetes de 500 soles queres?");
    billetera.BilletesDe500 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cuántos billetes de 1000 soles queres?");
    billetera.BilletesDe1000 = int.Parse(Console.ReadLine());
}