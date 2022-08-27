using System;

namespace md03_CadernoExercicios_03
{
    /*
     3. Crie um algoritmo que solicita ao usuário para digitar um número e mostrao por extenso. 
        Este número deve variar entre 1 e 10. Se o usuário introduzir
        um número que não está neste intervalo, mostre: "Número inválido".

     
     */

    class Program
    {
        static void Main(string[] args)
        {
            int converterTexto;
            string respostaUsuario = "UM", s = "S";

            do
            {
                Console.WriteLine("Digite um número entre 1 e 10:");
                converterTexto = Convert.ToInt32(Console.ReadLine());

                switch (converterTexto)
                {
                    case 1:
                        respostaUsuario = "UM";
                        break;
                    case 2:
                        respostaUsuario = "DOIS";
                        break;
                    case 3:
                        respostaUsuario = "TRÊS";
                        break;
                    case 4:
                        respostaUsuario = "QUATRO";
                        break;
                    case 5:
                        respostaUsuario = "CINCO";
                        break;
                    case 6:
                        respostaUsuario = "SEIS";
                        break;
                    case 7:
                        respostaUsuario = "SETE";
                        break;
                    case 8:
                        respostaUsuario = "OITO";
                        break;
                    case 9:
                        respostaUsuario = "NOVE";
                        break;
                    case 10:
                        respostaUsuario = "DEZ";
                        break;
                    default:
                        respostaUsuario = "Opção Inválida!";
                        break;
                }
                Console.WriteLine("Você digitou: " + respostaUsuario);
                Console.WriteLine("Deseja sair do sistema?\nDigite (S) para sair, ou (N) para permanecer no sistema.");
                s = Console.ReadLine();
                if (s == "s")
                {
                    s = "S";
                }
                else if (s == "n")
                {
                    s = "N";
                }

            } while (s == "N");
        }
    }
}
