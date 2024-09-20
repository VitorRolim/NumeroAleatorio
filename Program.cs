Random aleatorio = new Random();
int numaleatorio = aleatorio.Next(1, 100);
int num = 0;
int contador = 1;

do
{
    Console.WriteLine("Digite um um número entre 1 e 100:");
    num = int.Parse(Console.ReadLine());
    if (num > numaleatorio)
    {
        Console.WriteLine("O número é menor");
        contador++;
    }
    else if (num < numaleatorio)
    {
        Console.WriteLine("O número é maior");
        contador++;
    }
} while (num != numaleatorio);

Console.WriteLine("*********************************");
Console.WriteLine("Parabéns você adivinhou o número");
Console.WriteLine($"Você levou {contador} tentativas");
Console.WriteLine("*********************************");