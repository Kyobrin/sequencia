{
Console.WriteLine("\n-------------------------");
Console.WriteLine("\n    SEQUENCIA DE PARES   ");
Console.WriteLine("\n-------------------------");
int comeco = 0;
System.Console.WriteLine("Numeros pares entre 0 e");
int numero_escrito = Convert.ToInt32(Console.ReadLine());
while ( comeco <= numero_escrito)
{
    Console.Write($"{comeco} ");
    comeco += 2;
}

}
