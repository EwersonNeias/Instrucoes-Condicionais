using System;
//Biblioteca usada no codigo
class Program //Nomeando a classe
{
    static void Main(string[] args)
    {
        int num;  // Declaração da variável 'num' para armazenar o número digitado pelo usuário.
        
        Console.Write("Digite um numero inteiro positivo: ");  // Solicita ao usuário que digite um número inteiro positivo.
        num = int.Parse(Console.ReadLine());  // Lê a entrada do usuário como uma string e converte para um valor inteiro, atribuindo à variável 'num'.
        
        Console.Write("Os primeiros " + num + " Numeros pares são: ");  // Exibe uma mensagem informando a quantidade de números pares que serão exibidos.
        
        for (int i = 2; i <= num * 2; i += 2)  // Loop for que inicia em 2, incrementa de 2 em 2 e executa até que 'i' seja menor ou igual a 'num * 2'.
        {
            Console.Write(i + " ");  // Imprime o valor atual de 'i', seguido de um espaço em branco.
        }
        
        Console.WriteLine();  // Imprime uma nova linha após o loop for.
    }
}
