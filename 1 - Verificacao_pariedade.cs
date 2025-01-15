/* Crie um programa que peça ao usuário para digitar um número inteiro 
O programa deve verificar se o número é par ou ímpar. Utilize a condição 
if para determinar o resultado e exiba uma mensagem apropriada */


Console.WriteLine ("Por favor, escreva um numero");
int numero = int.Parse(Console.ReadLine());

//verifique se o número é inpar ou par

if (numero % 2 == 0)
 {
  Console.WriteLine("O número é par!");
} 

else
 {
  Console.WriteLine("O número é ímpar");
}


