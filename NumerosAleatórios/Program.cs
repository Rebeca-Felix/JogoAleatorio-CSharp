using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int numeroAleatorio = random.Next(1, 101);
        int tentativas = 0;
        int palpite;

        Console.WriteLine("Tente adivinhar o número entre 1 e 100:");

        do
        {
            Console.Write("Palpite: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out palpite))
            {
                tentativas++;

               if (palpite == numeroAleatorio)
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
                }
                else
                {

                    if (palpite < numeroAleatorio)
                    {
                        Console.WriteLine("Tente um número mais alto.");
                    }
                    else
                    {
                        Console.WriteLine("Tente um número mais baixo.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

        } while (palpite != numeroAleatorio);
    }
}
