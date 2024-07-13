using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // quantidade de lojas para dar carga
            int lojas = 22;

            // horário padrão de carga
            int horaCarga = 17;
            int minutoCarga = 00;

            while (true)
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                Console.WriteLine("\nMÉDIA DE ENVIO DE CARGA POR MINUTO!");
                Console.WriteLine("\n- - - - - - - - - - - - - - - - - -");
                Console.WriteLine("Digite a hora atual + QTD LOJAS JÁ GERADAS (EX: HORA:MINUTOS:LOJASGERADAS)\n");
                Console.Write(">>> ");

                // solicita usuário digitar horário em tempo real + QTD CARGA LJ GeRADA
                string[] vet = Console.ReadLine().Split(":");
                double horaAtual = double.Parse(vet[0]);
                double minutoAtual = double.Parse(vet[1]);
                int lojaCargasGeradas = int.Parse(vet[2]);

                while (lojaCargasGeradas > lojas || lojaCargasGeradas < 0)
                {
                    Console.WriteLine("\n- - - - - Valor incorreto - - - - -");
                    Console.WriteLine($"Valor: {lojaCargasGeradas}, incorreto");
                    Console.WriteLine("Favor Digite o Valor Correto: ");
                    Console.Write(">>> ");

                    lojaCargasGeradas = int.Parse(Console.ReadLine());

                }

                // calculando hora em valor decimal (Ex: 1,5 horas)
                double calculoHora = (horaAtual - horaCarga);
                double calculoMinuto = (minutoAtual - minutoCarga) / 60;

                // horas convertido em minutos
                double calculoConvertido = (calculoHora + calculoMinuto) * 60;

                Console.WriteLine($"\nConversão em minutos: {calculoConvertido}min");

                // valor médio de carga enviada por minuto
                double mediaDeCargaMinuto = calculoConvertido / lojaCargasGeradas;

                Console.WriteLine($"Media de Carga por Minuto: {mediaDeCargaMinuto.ToString("F2")}");

                Console.WriteLine("\nDeseja realizar nova operação? s/n: ");
                string confirmacao = Console.ReadLine();
                
                if (confirmacao == "n" || confirmacao == "N") {
                    break;
                }
            }

        }
    }
}