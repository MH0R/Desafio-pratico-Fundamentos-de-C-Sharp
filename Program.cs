using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Olá, digite seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}! Seja muito bem-vindo!");

        Exercicio2("Thalles", "Oliveira");
        Exercicio3(1.5, 1.5); 
        Exercicio4("Umdois"); 
        
        Console.WriteLine(Exercicio5("AAC1234")); 
        Exercicio6();

    }

    static void Exercicio2(string nome, string sobrenome) => Console.WriteLine($"{nome} {sobrenome}");

    static void Exercicio3(double primeiroValor, double segundoValor)
    {
        double resultadoSoma = primeiroValor + segundoValor;
        double resultadoSubtracao = primeiroValor - segundoValor;
        double resultadoMultiplicacao = primeiroValor * segundoValor;
        double resultadoDivisao = segundoValor != 0 ? primeiroValor / segundoValor : 0;
        double resultadoMedia =  (primeiroValor + segundoValor) / 2 ;

        Console.WriteLine($"Soma {resultadoSoma}, Subtração {resultadoSubtracao}, Multiplicação {resultadoMultiplicacao}, Divisão {resultadoDivisao}, Média {resultadoMedia}");



    }

    static void Exercicio4(string caractere) 
    {
        int resultLenght = caractere.Count();

        Console.WriteLine(resultLenght);
    }

    static bool Exercicio5(string placaVeiculo)
    { 
        string padrao = @"^[a-zA-Z]{3}\d{4}$";

        return Regex.IsMatch(placaVeiculo, padrao);
    }

    static void Exercicio6()
    {
        Console.WriteLine("Escolha o formato para exibir a data atual:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato dd/MM/yyyy");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        int respostaUsuario = int.Parse(Console.ReadLine());

        DateTime dataAtual = DateTime.Now;

        switch (respostaUsuario)
        {
            case 1:
                // Formato completo
                Console.WriteLine(dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                break;

            case 2:
                // Apenas a data no formato dd/MM/yyyy
                Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
                break;

            case 3:
                // Apenas a hora no formato de 24 horas
                Console.WriteLine(dataAtual.ToString("HH:mm"));
                break;

            case 4:
                // Data com o mês por extenso (em português)
                Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }


    }
}