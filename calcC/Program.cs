using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcC
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = @"
            -------------------------------------------------------------------
            #            _            _           _                           #
            #           | |          | |         | |                          #
            #   ___ __ _| | ___ _   _| | __ _  __| | ___  _ __ __ _           #
            #  / __/ _` | |/ __| | | | |/ _` |/ _` |/ _ \| '__/ _` |          #
            # | (_| (_| | | (__| |_| | | (_| | (_| | (_) | | | (_| |          #
            #  \___\__,_|_|\___|\__,_|_|\__,_|\__,_|\___/|_|  \__,_|          #
            #                                                                 #
            #                                                                 #
            #      _ _ _ _                                                    #
            #     (_) | (_)                                                   #
            #  ___ _| | |_ ___                                                #
            # / __| | | | / __|                                               #
            # \__ \ | | | \__ \                                               #
            # |___/_|_|_|_|___/                                               #
            #                                                                 #
            #  construida: israel albuquerque                                 #
            #  github: leoisrael                                              #
            #  versao: 1.3.0                                                  #                           
            -------------------------------------------------------------------
            ";

            string menu = @"
    uso: calcC  [--help] [-h]  (retorna menu de argumentos)
                [soma] [+] <valor> <valor>...  (soma pode receber quantos argumentos forem necessarios)       
                [subtracao] [-] <valor> <valor> (recebe dois valores para o calculo)
                [fatoracao] [!] <valor> (recebe um valor para o calculo)
                [divisao] [/] <valor> <valor>   (recebe dois valores para o calculo)
    ----------------------------------------------------------------------------------------------------
    exemplo:    calcC soma 2 2 2
                calcC ! 7
            ";

            //ajuda
            if (args[0] == "-h" || args[0] == "--help")
            {
                Console.WriteLine(title);
                Console.WriteLine(menu);
                Environment.Exit(0);
            }

            //error
            if (args.Length == 0)
            {
                error();
            }

            //operador
            string operador = args[0];

            //operacoes
            //soma
            if (args[0] == "+" || args[0] == "soma")
            {
                int resultado = 0;
                for (int i = 1; i < args.Length; i++)
                {
                    int value = Convert.ToInt32(args[i]);
                    resultado += value;
                }
                Console.WriteLine("resultado: " + resultado);
            }

            //fatoracao
            if (args[0] == "!" || args[0] == "fatoracao")
            {
                double resultado = 1;
                double numero = Convert.ToDouble(args[1]);
                while (numero != 1)
                {
                    resultado = resultado * numero;
                    numero = numero - 1;
                }
                Console.WriteLine("resultado: " + resultado);
            }

            //subtracao
            if (args[0] == "-" || args[0] == "subtracao")
            {
                int resultado;
                int a = Convert.ToInt32(args[1]);
                int b = Convert.ToInt32(args[2]);
                resultado = a - b;
                Console.WriteLine("resultado: " + resultado);
            }

            //divisao
            if (args[0] == "/" || args[0] == "divisao")
            {
                try
                {
                    int resultado;
                    int a = Convert.ToInt32(args[1]);
                    int b = Convert.ToInt32(args[2]);
                    resultado = a / b;
                    Console.WriteLine("resultado: " + resultado);
                }
                catch (Exception e)
                {
                    Console.WriteLine("voce nao pode fazer divisao por zero!", e);
                }
            }
        }

        static void error()
        {
            string menu = @"
    uso: calcC  [--help] [-h]  (retorna menu de argumentos)
                [soma] [+] <valor> <valor>...  (soma pode receber quantos argumentos forem necessarios)       
                [subtracao] [-] <valor> <valor> (recebe dois valores para o calculo)
                [fatoracao] [!] <valor> (recebe um valor para o calculo)
                [divisao] [/] <valor> <valor>   (recebe dois valores para o calculo)
    ----------------------------------------------------------------------------------------------------
    exemplo:    calcC soma 2 2 2
                calcC ! 7
            ";
            Console.WriteLine(menu);
            Environment.Exit(0);
        }
    }
}
