using System;
//Biblioteca usada no codigo
class Program //Nomeando a classe
{
    static void Main(string[] args)
    {
        int numero;  // Declaração da variável 'numero' para armazenar os valores de 1 a 10.
        
        for (numero = 1; numero <= 10; numero++)  // Loop for que inicia em 1, executa enquanto 'numero' for menor ou igual a 10, e incrementa 'numero' em 1 a cada iteração.
        {
            Console.WriteLine("Numero ...: " + numero);  // Imprime a mensagem "Numero ...: " seguida pelo valor atual de 'numero'.
        }
    }
}
