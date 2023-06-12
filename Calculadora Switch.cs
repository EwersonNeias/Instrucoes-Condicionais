using System;

class Program //Nomeando a classe
{
    static void Main(string[] args)
    {
        char op; // Declaração da variável 'op' para armazenar o operador escolhido pelo usuário.
        float num1, num2; // Declaração das variáveis 'num1' e 'num2' para armazenar os valores inseridos pelo usuário.
        
        Console.Write("ENTRE COM O OPERADOR: +, -, *, /: "); // Solicita ao usuário que entre com o operador desejado.
        op = Console.ReadLine()[0]; // Lê a entrada do usuário como uma string e armazena o primeiro caractere na variável 'op'.
        
        Console.Write("ENTRE COM DOIS VALORES: "); // Solicita ao usuário que entre com dois valores separados por espaço.
        string[] inputs = Console.ReadLine().Split(' '); // Lê a entrada do usuário como uma string e divide-a em um array de strings com base no espaço em branco.
        num1 = float.Parse(inputs[0]); // Converte a primeira string do array em um valor float e atribui-o à variável 'num1'.
        num2 = float.Parse(inputs[1]); // Converte a segunda string do array em um valor float e atribui-o à variável 'num2'.
        
        switch (op) // Início da estrutura de controle switch com base no valor de 'op'.
        {
            case '+': // Caso 'op' seja '+':
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); // Imprime a soma dos valores 'num1' e 'num2'.
                break; // Sai do switch.
            case '-': // Caso 'op' seja '-':
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); // Imprime a subtração dos valores 'num1' e 'num2'.
                break; // Sai do switch.
            case '*': // Caso 'op' seja '*':
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}"); // Imprime o produto dos valores 'num1' e 'num2'.
                break; // Sai do switch.
            case '/': // Caso 'op' seja '/':
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}"); // Imprime a divisão dos valores 'num1' e 'num2'.
                break; // Sai do switch.
            default: // Caso 'op' não seja nenhum dos operadores acima:
                Console.WriteLine("OPERADOR ERRADO, POR FAVOR INSIRA O OPERADOR CORRETO"); // Imprime uma mensagem informando que o operador inserido está incorreto.
                break; // Sai do switch.
        }
    }
}
