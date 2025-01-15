       
        Console.Write("Digite o valor da sua compra: R$ ");
        double valorCompra = double.Parse(Console.ReadLine());

        if (valorCompra > 100)
        {
            
            double desconto = valorCompra * 0.10;
            valorCompra -= desconto; 
            Console.WriteLine($"Valor com desconto: R$ {valorCompra}");
        }
        else
        {
            Console.WriteLine($"Valor original: R$ {valorCompra}");
        }
    