using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do estudante:");
        string nome = Console.ReadLine();  

        double soma = 0;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Digite a nota " + i + ":");
            string notaTexto = Console.ReadLine();
      
            double nota;
            if (!double.TryParse(notaTexto, out nota))
            {
                Console.WriteLine("Entrada inválida! Usando 0.");
                nota = 0;
            }
            soma += nota;
        }

        double media = soma / 3.0; 

        Console.WriteLine("A média do estudante " + nome + " é " + media.ToString("F2"));
    }
}

