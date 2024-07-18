using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("| MÉDIA DE ENVIO DE CARGA POR MINUTO! |");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - \n");

            Console.Write("Digite Horário inicial da carga: ");
            string[] horarioCargaInicial = Console.ReadLine().Split(':');
            int horaCarga = int.Parse(horarioCargaInicial[0]);
            int minutoCarga = int.Parse(horarioCargaInicial[1]);

            while (horaCarga < 17)
            {
                Console.Clear();
                Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("| MÉDIA DE ENVIO DE CARGA POR MINUTO! |");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - \n");
                Console.WriteLine($"Valor Hora {horaCarga} inválido. Digite novamente.");
                Console.Write("Digite Horário inicial da carga: ");
                horarioCargaInicial = Console.ReadLine().Split(':');
                horaCarga = int.Parse(horarioCargaInicial[0]);
                minutoCarga = int.Parse(horarioCargaInicial[1]);
            }

            // quantidade de lojas para dar carga
            int lojas = 22;

            // horário padrão de carga
            /* int horaCarga = 17;
            int minutoCarga = 05;*/

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("| MÉDIA DE ENVIO DE CARGA POR MINUTO! |");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - \n");
                Console.WriteLine("Digite a hora atual + QTD CARGAS GERADAS\n(EX: HORA:MINUTOS:LOJASGERADAS)");
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

                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("|  |  |  | | | RESULTADO | | |  |  |  |");
                Console.WriteLine($"Início da carga: {horaCarga}:{minutoCarga}");
                Console.WriteLine($"Conversão em minutos: {calculoConvertido.ToString("F2")}min");

                // valor médio de carga enviada por minuto
                double mediaDeCargaMinuto = calculoConvertido / lojaCargasGeradas;

                Console.WriteLine($"Media de Carga por Minuto: {mediaDeCargaMinuto.ToString("F2")}min");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");

                Console.WriteLine("Deseja realizar nova operação? s/n: ");
                Console.Write(">>> ");
                string confirmacao = Console.ReadLine();


                
                if (confirmacao == "s" || confirmacao == "S")
                {
                    Console.Clear();
                    continue;
                }
                else if (confirmacao == "n" || confirmacao == "N")
                {
                    break;
                }
                else
                {
                    while (confirmacao != "s" || confirmacao != "S" || confirmacao != "n" || confirmacao != "N")
                    {
                        Console.Clear();
                        Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine("| MÉDIA DE ENVIO DE CARGA POR MINUTO! |");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine("\\\\\\\\\\\\\\ RESULTADO //////////////");
                        Console.WriteLine($"Início da carga: {horaCarga}:{minutoCarga.ToString("F2")}");
                        Console.WriteLine($"Conversão em minutos: {calculoConvertido.ToString("F2")}min");
                        Console.WriteLine($"Media de Carga por Minuto: {mediaDeCargaMinuto.ToString("F2")}min");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine($"Valor ínválido: {confirmacao}\nDeseja realizar nova operação? s/n: ");
                        Console.Write(">>> ");
                        string confirmacaoWhile = Console.ReadLine();
                        confirmacao = confirmacaoWhile;
                        //Verificar loop infinito, corrigir;
                    }
                }
            }
        }
    }
}