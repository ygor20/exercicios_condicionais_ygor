
Console.WriteLine ("Por favor, digite a sua nota!");
int nota = int.Parse (Console.ReadLine());


if (nota >= 9)

{
    Console.WriteLine ("Excelente!");
}

else if (nota >= 7)

{
    Console.WriteLine("Boa!");
}

else if (nota >= 5)

{
    Console.WriteLine("Regular!");
}



else
{
    Console.WriteLine ("Baixa!");
}
