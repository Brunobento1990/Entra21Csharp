using System;

namespace AppContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double saque, deposito, transfere;
            string[] Usuario = new string[] { "Bruno", "Meri", "Lari", "Maria", "Caina", "João" };
            double[] Valor = new double[] { 1000, 2000, 3000, 4000, 5000 };
            Console.WriteLine("---> MENU <--- \n\n --> Insira o número da operação\n \n 1 --> Sacar \n 2 --> Depositar \n 3 --> Transferir \n 0 --> Sair");
            double opera = Convert.ToDouble(Console.ReadLine());

            if (opera == 0)
            {
                Console.WriteLine("--> Programa finalizado !");
            }
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
                            Console.WriteLine("---> Saldo insuficiente !");
                        }
                        if (saque < Valor[i])
                        {
                            Valor[i] = Valor[i] - saque;
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
                        Console.WriteLine($"---> O usuário {Usuario[i]} recebeu um depósito de " + deposito + $" seu saldo atual é de {Valor[i]}");
                    }

                }
            }
            if (opera == 3)
            {
                Console.WriteLine("---> Insira o usuário da conta que sairá o valor !");
                string contaSair = Console.ReadLine();
                Console.WriteLine("---> Agora insira o usuário da conta que receberá o valor !");
                string contaReceber = Console.ReadLine();
                Console.WriteLine("---> Qual valor a ser transferido !");
                transfere = Convert.ToDouble(Console.ReadLine());

                for(int i =0;i < Usuario.Length; i++)
                {
                    if(contaSair == Usuario[i])
                    {
                        Valor[i] = Valor[i] - transfere;
                        Console.WriteLine($"---> Foi transferido do usuário {Usuario[i]} um valor de " + transfere + $" seu saldo atual é {Valor[i]}");
                    }
                    if(contaReceber == Usuario[i])
                    {
                        Valor[i] = Valor[i] + transfere;
                        Console.WriteLine($"---> O usuário {Usuario[i]} recebeu uma transfêrencia de "+transfere+$" seu saldo atual é {Valor[i]}");
                    }
                }
            }

        }
    }
}
