using System;

namespace AppContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int saque, deposito, transfere;
            string[] Usuario = new string[] { "Bruno", "Meri", "Lari", "Maria", "Caina", "João" };
            int[] Valor = new int[] { 1000, 2000, 3000, 4000, 5000 };
            Console.WriteLine("---> MENU <--- \n\n --> Insira o número da operação\n \n 1 --> Sacar \n 2 --> Depositar \n 3 --> Transferir \n 0 --> Sair");
            int opera = Convert.ToInt32(Console.ReadLine());

            if (opera == 0)
            {
                Console.WriteLine("--> Programa finalizado !");
            }
            if (opera == 1)
            {
                Console.WriteLine("--> Insira seu nome :");
                string nome = Console.ReadLine();
                for (int i = 0; i < Usuario.Length; i++)
                {
                    if (nome == Usuario[i])
                    {
                        Console.WriteLine("--> Insira o valor a ser sacado ");
                        saque = Convert.ToInt32(Console.ReadLine());
                        if (saque > Valor[i])
                        {
                            Console.WriteLine("---> Saldo insuficiente !");
                        }
                        if (saque < Valor[i])
                        {
                            Valor[i] = Valor[i] - saque;
                            //Console.WriteLine(Valor[i]);
                        }
                    }
                }
            }
            if (opera == 2)
            {
                Console.WriteLine("---> Insira a conta a ser depositada !");
                string conta = Console.ReadLine();
                for (int i = 0; i < Usuario.Length; i++)
                {

                    if (conta == Usuario[i])
                    {
                        Console.WriteLine("---> insira o valor a ser depositado !");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        Valor[i] = Valor[i] + deposito;
                        //Console.WriteLine(Valor[i]);
                    }

                }
            }
            if (opera == 3)
            {
                Console.WriteLine("---> Insira a conta que sairá o valor !");
                string contaSair = Console.ReadLine();
                Console.WriteLine("---> Agora insira a conta que receberá o valor !");
                string contaReceber = Console.ReadLine();
                Console.WriteLine("---> Qual valor a ser transferido !");
                transfere = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < Usuario.Length; i++)
                {
                    for(int j = 0;j< Valor.Length; j++)
                    {
                        if (transfere > Valor[j])
                        {

                        }
                    }

                    //if (contaSair == Usuario[i])
                    //{
                    //    if (transfere < Valor[i])
                    //    {
                    //        Console.WriteLine("---> Saldo insuficiente !");
                    //    }
                    //    if (transfere > Valor[i])
                    //    {
                    //        //Valor[i] = Valor[i] + transfere;
                    //        //Console.WriteLine(Valor[i]);
                    //    }
                    //}
                }
            }

        }
    }
}
