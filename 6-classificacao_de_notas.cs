
Console.WriteLine ("Por favor, digite a sua nota!");
idouble nota = double.Parse (Console.ReadLine());


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
