using System;
//Biblioteca usada no codigo
class Program
{
    static void Main(string[] args)
    {
        int num, i = 1;  // Declaração das variáveis 'num' e 'i' e inicialização de 'i' como 1.
        
        Console.Write("Digite um numero inteiro positivo: ");  // Solicita ao usuário que digite um número inteiro positivo.
        num = int.Parse(Console.ReadLine());  // Lê a entrada do usuário como uma string e converte para um valor inteiro, atribuindo à variável 'num'.
        
        while (i <= num)  // Enquanto 'i' for menor ou igual ao valor de 'num'.
        {
            Console.Write(i + " ");  // Imprime o valor de 'i' seguido de um espaço em branco.
            i++;  // Incrementa o valor de 'i' em 1.
        }
        
        Console.WriteLine();  // Imprime uma nova linha após o loop while.
    }
}
