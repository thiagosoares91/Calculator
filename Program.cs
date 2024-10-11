
namespace Calculator;

class Program
{
    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Qual operação deseja realizar?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("--------------------");
        Console.WriteLine("Selecione uma opção: ");
        short resultado;

        while (true)
        {
            string input = Console.ReadLine() ?? "0";

            if (short.TryParse(input, out resultado) && resultado >= 1 && resultado <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida! Por favor, insira um número entre 1 e 5.");
            }
        }

        switch (resultado)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Agradecimento(); System.Environment.Exit(0); break;
            default:
                Console.WriteLine("Insira uma operação valida");
                Console.ReadKey();
                Menu(); break;

        }


    }

    static void Soma()
    {
        Console.Clear();
        float v1, v2;

        while (true)
        {
            Console.WriteLine("Primeiro valor: ");
            string input1 = Console.ReadLine() ?? "0";
            if (float.TryParse(input1, out v1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        while (true)
        {
            Console.WriteLine("Segundo valor: ");
            string input2 = Console.ReadLine() ?? "0";
            if (float.TryParse(input2, out v2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        float resultado = v1 + v2;
        Console.WriteLine($"O resultado da soma é {resultado}");

        Console.WriteLine("\nDeseja continuar a operação ou voltar ao menu?");
        Console.WriteLine("1 - Somar novamente");
        Console.WriteLine("2 - Voltar ao menu");

        if (!short.TryParse(Console.ReadLine(), out short escolha))
        {
            escolha = 0;
        }

        switch (escolha)
        {
            case 1:
                Soma();
                break;
            case 2:
                Menu();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
                Menu();
                break;
        }
    }


    static void Subtracao()
    {
        Console.Clear();
        float v1, v2;


        while (true)
        {
            Console.WriteLine("Primeiro valor:");
            string input1 = Console.ReadLine() ?? "0";
            if (float.TryParse(input1, out v1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }


        while (true)
        {
            Console.WriteLine("Segundo valor:");
            string input2 = Console.ReadLine() ?? "0";
            if (float.TryParse(input2, out v2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        float resultado = v1 - v2;
        Console.WriteLine($"\nO resultado da subtração é {resultado}");

        Console.WriteLine("\nDeseja continuar a operação ou voltar ao menu?");
        Console.WriteLine("1 - Subtrair novamente");
        Console.WriteLine("2 - Voltar ao menu");

        if (!short.TryParse(Console.ReadLine(), out short escolha))
        {
            escolha = 0;
        }

        switch (escolha)
        {
            case 1:
                Subtracao();
                break;
            case 2:
                Menu();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
                Menu();
                break;
        }
    }


    static void Divisao()
    {
        Console.Clear();
        float v1, v2;

        while (true)
        {
            Console.WriteLine("Primeiro valor:");
            string input1 = Console.ReadLine() ?? "";
            if (float.TryParse(input1, out v1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        while (true)
        {
            Console.WriteLine("Segundo valor:");
            string? input2 = Console.ReadLine();
            if (input2 is not null && float.TryParse(input2, out v2))
            {
                if (v2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero. Tente novamente.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        float resultado = v1 / v2;
        Console.WriteLine($"\nO resultado da divisão é {resultado}");

        Console.WriteLine("\nDeseja continuar a operação ou voltar ao menu?");
        Console.WriteLine("1 - Dividir novamente");
        Console.WriteLine("2 - Voltar ao menu");

        if (!short.TryParse(Console.ReadLine(), out short escolha))
        {
            escolha = 0;
        }

        switch (escolha)
        {
            case 1:
                Divisao();
                break;
            case 2:
                Menu();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
                Menu();
                break;
        }
    }


    static void Multiplicacao()
    {
        Console.Clear();
        float v1, v2;

        while (true)
        {
            Console.WriteLine("Primeiro valor:");
            string input1 = Console.ReadLine() ?? "0";
            if (float.TryParse(input1, out v1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        while (true)
        {
            Console.WriteLine("Segundo valor:");
            string input2 = Console.ReadLine() ?? "0";
            if (float.TryParse(input2, out v2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        float resultado = v1 * v2;
        Console.WriteLine($"\nO resultado da multiplicação é {resultado}");

        Console.WriteLine("\nDeseja continuar a operação ou voltar ao menu?");
        Console.WriteLine("1 - Multiplicar novamente");
        Console.WriteLine("2 - Voltar ao menu");

        short escolha = short.Parse(Console.ReadLine() ?? "0");

        switch (escolha)
        {
            case 1:
                Multiplicacao();
                break;
            case 2:
                Menu();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
                Menu();
                break;
        }
    }


    static void Agradecimento()
    {
        Console.WriteLine("Obrigado por usar o programa! Volte sempre!!!!!");
    }

}
