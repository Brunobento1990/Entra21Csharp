using System;

namespace AppContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double saque, deposito,transfere;
            string[] Usuario = new string[] { "Bruno", "Meri", "Lari", "Maria", "Caina", "João" };
            double[] Valor = new double[] { 1000, 2000, 3000, 4000, 5000 };
            double opera ;
            Console.WriteLine();
            Console.WriteLine("---> MENU <--- \n\n --> Insira o número da operação\n \n 1 --> Sacar \n 2 --> Depositar \n 3 --> Transferir \n 0 --> Sair");
            opera = Convert.ToDouble(Console.ReadLine());

            while (opera > 0)
            {
               
                if (opera == 1)
                {
                    Console.WriteLine("--> Insira seu nome do usúario da conta !");
                    string nome = Console.ReadLine();
                    for (int i = 0; i < Usuario.Length; i++)
                    {
                        if (nome == Usuario[i])
                        {
                            Console.WriteLine("--> Insira o valor a ser sacado !");
                            saque = Convert.ToDouble(Console.ReadLine());
                            if (saque > Valor[i])
                            {
                                Console.WriteLine();
                                Console.WriteLine("---> Saldo insuficiente !");
                            }
                            if (saque <= Valor[i])
                            {
                                Valor[i] = Valor[i] - saque;
                                Console.WriteLine();
                                Console.WriteLine($" ---> A conta de { Usuario[i]} está com saldo atual de { Valor[i]}. ");
                            }
                        }
                    }
                }
                if (opera == 2)
                {
                    Console.WriteLine("---> Insira o nome do usuário da conta a ser depositada !");
                    string conta = Console.ReadLine();
                    for (int i = 0; i < Usuario.Length; i++)
                    {

                        if (conta == Usuario[i])
                        {
                            Console.WriteLine("---> insira o valor a ser depositado !");
                            deposito = Convert.ToDouble(Console.ReadLine());
                            Valor[i] = Valor[i] + deposito;
                            Console.WriteLine();
                            Console.WriteLine($"---> O usuário {Usuario[i]} recebeu um depósito de " + deposito + $" seu saldo atual é de {Valor[i]}");
                        }
                    }
                }
                if (opera == 3)
                {
                    Console.WriteLine("---> Insira o usuário da conta que sairá o valor !");
                    string contaSair = Console.ReadLine();
                    Console.WriteLine("---> Qual valor a ser transferido !");
                    transfere = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("---> Agora insira o usuário da conta que receberá o valor !");
                    string contaReceber = Console.ReadLine();

                    for (int i = 0; i < Valor.Length; i++)
                    {
                        for(int j = 0; j < Valor.Length; j++)
                        {
                            if (transfere > Valor[i])
                            {
                                Console.WriteLine();
                                Console.WriteLine($"---> Saldo insuficiente na conta {Usuario[i]}");
                            }
                            if (transfere <= Valor[i]  && contaSair == Usuario[i] && contaReceber == Usuario[j])
                            {
                                Valor[i] = Valor[i] - transfere;
                                Valor[j] = Valor[j] + transfere;
                                Console.WriteLine();
                                Console.WriteLine($"---> Foi transferido do usuário {Usuario[i]} um valor de " + transfere + $" seu saldo atual é {Valor[i]}");
                                Console.WriteLine();
                                Console.WriteLine($"---> O usuário {Usuario[j]} recebeu uma transferencia de " + transfere + $" seu saldo atual é {Valor[j]}");
                            }
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("---> MENU <--- \n\n --> Insira o número da operação\n \n 1 --> Sacar \n 2 --> Depositar \n 3 --> Transferir \n 0 --> Sair");
                opera = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
