namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("DIAMANTE DE LETRAS");
            Console.WriteLine();

            int letraA = 'A'; //65+

            Console.Write("Informe a letra do alfabeto que deseja como ponto mais distante do diamante: ");
            int letraDoMeio = Console.ReadLine().ToUpper()[0];

            int quantidadeEspacosFora = letraDoMeio - letraA;
            int quantidadeEspacosDentro = -1;

            for (int i = letraA; i < letraDoMeio; i++)
            {
                for (int j = 0; j < quantidadeEspacosFora; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(Convert.ToChar(i));

                for (int k = 0; k < quantidadeEspacosDentro; k++)
                {
                    Console.Write(" ");
                }

                if (i != letraA)
                {
                    Console.Write(Convert.ToChar(i));
                }

                Console.WriteLine();

                quantidadeEspacosFora--;
                quantidadeEspacosDentro += 2;
            }

            for (int i = letraDoMeio; i >= letraA; i--)
            {
                for (int j = 0; j < quantidadeEspacosFora; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(Convert.ToChar(i));

                for (int k = 0; k < quantidadeEspacosDentro; k++)
                {
                    Console.Write(" ");
                }

                if (i != letraA)
                {
                    Console.Write(Convert.ToChar(i));
                }

                Console.WriteLine();

                quantidadeEspacosFora++;
                quantidadeEspacosDentro -= 2;
            }

        }
    }
}