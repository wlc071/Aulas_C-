using System;
using System.Threading;

namespace Menuzao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, i = 0;
            double result = 0, num = 0;
            while (opc != 8)
            {
                Console.WriteLine("========================== M E N U ==========================");
                Console.WriteLine("- ESCOLHA UMA DAS OPÇÕES E APERTE ENTER.");
                Console.WriteLine("=============================================================");
                Console.WriteLine("1. Resistência equivalente entre dois resistores.");
                Console.WriteLine("2. Distância entre dois pontos.");
                Console.WriteLine("3. IMC - Indice de massa corporal");
                Console.WriteLine("4. Tabuada.");
                Console.WriteLine("5. Raiz quadrada.");
                Console.WriteLine("6. Potenciação.");
                Console.WriteLine("7. Fatorial.");
                Console.WriteLine("8. Finalizar aplicação.");
                Console.WriteLine("--------------------------------------------------------------");
                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());
                while ((opc < 1) || (opc > 8))
                {
                    Console.Write("Opção inválida. Corrija: ");
                    opc = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        opc = 0;
                        double r1 = 0, r2 = 0, req = 0;

                        while (opc != 2)
                        {
                            Console.WriteLine("\t\t <<<< RESISTÊNCIA EQUIVALENTE ENTRE DOIS RESISTORES >>>>");
                            Console.WriteLine("");
                            Console.WriteLine("-> Informe os valores dos resistores.");
                            Console.WriteLine("-> [1] Para iniciar / [2] Para finalizar.");
                            opc = int.Parse(Console.ReadLine());
                            while ((opc < 1) || (opc > 2))
                            {
                                Console.Write("Inválido. Corrija: ");
                                opc = int.Parse(Console.ReadLine());
                            }
                            if (opc == 2)
                            {
                                Console.WriteLine("Finalizando...[PRECIONE QUALQUER TECLA]");
                            }
                            else
                            {
                                Console.Write("Resistor R1: ");
                                r1 = double.Parse(Console.ReadLine());
                                while (r1 < 0)
                                {
                                    Console.Write("Valor negativo inválido. Corrija:");
                                    r1 = double.Parse(Console.ReadLine());
                                }

                                Console.Write("Resistor R2: ");
                                r2 = double.Parse(Console.ReadLine());
                                while (r2 < 0)
                                {
                                    Console.Write("Valor negativo inválido. Corrija:");
                                    r2 = double.Parse(Console.ReadLine());
                                }

                                req = (r1 * r2) / (r1 + r2);
                                Console.WriteLine("");
                                Console.WriteLine("Resistência equivalente = " + req);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Thread.Sleep(1000);
                        break;
                    case 2:
                        Console.WriteLine("\t\t <<<< DISTÂNCIA ENTRE DOIS PONTOS >>>>");
                        Console.WriteLine("");
                        Console.WriteLine("- Informe a posição dos dois pontos cartesianos.");
                        Console.WriteLine("");

                        Console.Write("X1 = "); //Valor do X no primeiro ponto.
                        double x1 = double.Parse(Console.ReadLine());

                        Console.Write("Y1 = "); //Valor do Y no primeiro ponto.
                        double y1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        Console.Write("X2 = "); //Valor do X no segundo ponto.
                        double x2 = double.Parse(Console.ReadLine());

                        Console.Write("Y2 = "); //Valor do Y no segundo ponto.
                        double y2 = double.Parse(Console.ReadLine());

                        double oper_1 = Math.Pow((x1 - x2), 2); //Função Math.Pow para calculo com expoente.
                        double oper_2 = Math.Pow((y1 - y2), 2);
                        double distancia = Math.Sqrt(oper_1 + oper_2); //Função Math.Sqrt para calcular raiz.
                        Console.WriteLine("");

                        Console.WriteLine("A distância entre os pontos é " + distancia);
                        Console.ReadKey();
                        Thread.Sleep(1000);
                        break;

                    case 3:
                        Console.WriteLine("\t\t <<< INDICE DE MASSA CORPORAL (IMC) >>>");
                        Console.WriteLine("");
                        Console.WriteLine("-> Entre com os dados pedidos.");

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Sexo - (m) Masculino / (f) Feminino : ");
                        string sexo = Console.ReadLine();
                        while ((sexo != "m") && (sexo != "f"))
                        {
                            Console.Write("Opção inválida. Corrija: ");
                            sexo = Console.ReadLine();
                        }

                        Console.Write("Peso (kg): ");
                        float peso = float.Parse(Console.ReadLine());

                        Console.Write("Altura (m): ");
                        float altura = float.Parse(Console.ReadLine());

                        Console.Write("Data de nascimento (DD/MM/AAAA): ");
                        string nascimento = Console.ReadLine();
                        DateTime dataNasc = Convert.ToDateTime(nascimento); // DateTime tipo de variavel para data, usando convert
                        int anos = DateTime.Now.Year - dataNasc.Year;

                        while (anos < 0)        // Validar a idade, caso seja digitado um ano maior que o atual
                        {
                            Console.Write("Data inválida. Corrija: ");
                            nascimento = Console.ReadLine();
                            dataNasc = Convert.ToDateTime(nascimento);
                            anos = DateTime.Now.Year - dataNasc.Year;
                        }

                        int mes = DateTime.Now.Month - dataNasc.Month; // Verificar se a pessoa fez aniversario esse ano usando o mês
                        int dia = DateTime.Now.Day - dataNasc.Day;      // Verificar se fez aniversario esse mês usando o dia

                        if (mes < 0)
                        {
                            anos = anos - 1;
                        }
                        else if (dia < 0)
                        {
                            anos = anos - 1;
                        }

                        Console.WriteLine("- Resultado:\nIdade: " + anos + " anos");

                        double imc = peso / (altura * altura);
                        imc = Math.Round(imc, 2);
                        Console.WriteLine("Imc: " + imc);

                        if (imc < 17)
                        {
                            Console.WriteLine("Está muito abaixo do peso ideal.");
                            Console.ReadKey();
                        }
                        else if ((imc >= 17) && (imc <= 18.49))
                        {
                            Console.WriteLine("Está abaixo do peso ideal.");
                            Console.ReadKey();
                        }
                        else if ((imc >= 18.5) && (imc <= 24.99))
                        {
                            Console.WriteLine("Está com peso normal.");
                            Console.ReadKey();
                        }
                        else if ((imc >= 25) && (imc <= 29.99))
                        {
                            Console.WriteLine("Está acima do peso.");
                            Console.ReadKey();
                        }
                        else if ((imc >= 30) && (imc <= 34.99))
                        {
                            Console.WriteLine("Obesidade I.");
                            Console.ReadKey();
                        }
                        else if ((imc >= 35) && (imc <= 39.99))
                        {
                            Console.WriteLine("Obesidade II (Severa).");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Obesidade III (Mórbida).");
                            Console.ReadKey();
                        }
                        Thread.Sleep(1000);
                        break;

                    case 4:
                        opc = 0; i = 0;
                        num = 0; result = 0;
                        while (opc != 5)
                        {
                            Console.WriteLine("-------------<<< Tabuada de 1 a 10 >>>-------------");
                            Console.WriteLine("- Escolha uma opção para resultar sua tabuada.");
                            Console.WriteLine("1 - Tabuada de adição.");
                            Console.WriteLine("2 - Tabuada de subtração.");
                            Console.WriteLine("3 - Tabuada de multiplicação.");
                            Console.WriteLine("4 - Tabuada de divisão.");
                            Console.WriteLine("5 - Sair.");
                            Console.Write("Opção: ");
                            opc = int.Parse(Console.ReadLine());
                            while ((opc < 1) || (opc > 5))
                            {
                                Console.Write("Opção inválida. Corrija: ");
                                opc = int.Parse(Console.ReadLine());
                            }
                            if (opc == 5)
                            {
                                Console.WriteLine("- Finalizando... [PRESSIONE QUALQUER TECLA]");
                            }
                            else
                            {
                                Console.Write("Tabuada do número: ");
                                num = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 1:
                                        for (i = 1; i <= 10; i++)
                                        {
                                            result = num + i;
                                            Console.WriteLine(num + " + " + i + " = " + result);
                                        }
                                        break;
                                    case 2:
                                        for (i = 1; i <= 10; i++)
                                        {
                                            result = num - i;
                                            Console.WriteLine(num + " - " + i + " = " + result);
                                        }
                                        break;
                                    case 3:
                                        for (i = 1; i <= 10; i++)
                                        {
                                            result = num * i;
                                            Console.WriteLine(num + " * " + i + " = " + result);
                                        }
                                        break;
                                    case 4:
                                        for (i = 1; i <= 10; i++)
                                        {
                                            result = num / i;
                                            Console.WriteLine(num + " / " + i + " = " + result);
                                        }
                                        break;
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Thread.Sleep(1000);
                        break;
                    case 5:
                        result = 0; num = 0;
                        opc = 0;

                        while (opc != 2)
                        {
                            Console.WriteLine("\t-############ CALCULAR RAIZ QUADRADA ############-");
                            Console.WriteLine("==================================================================");
                            Console.WriteLine("-> Digite um número positivo maior ou igual a zero.");
                            Console.WriteLine("-> Para iniciar digite 1, ou 2 para sair.");
                            Console.WriteLine("==================================================================");
                            Console.WriteLine("   1 = Iniciar cálculo.\n   2 = Sair.");
                            Console.Write("   Opç: ");
                            opc = int.Parse(Console.ReadLine());

                            while ((opc < 1) || (opc > 2))
                            {
                                Console.Write("-- Opção inválida. Corrija: ");
                                opc = int.Parse(Console.ReadLine());
                            }

                            if (opc == 2)
                            {
                                Console.WriteLine("\nFinalizando... [ PRESSIONE QUALQUER TECLA ]");
                            }
                            else
                            {
                                Console.Write("\n> Número: ");
                                num = double.Parse(Console.ReadLine());
                                result = Math.Sqrt(num);
                                Console.WriteLine("\nSua raiz quadrada é: " + result + "\n\n\n\t     [Pressione ENTER para continuar]");
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }
                        Thread.Sleep(1000);
                        break;

                    case 6:
                        opc = 0;

                        while (opc != 2)
                        {
                            Console.WriteLine("--------<<<< POTENCIA ENTRE DOIS VALORES >>>>--------");
                            Console.WriteLine("> Calcular informando a base e o expoente.");
                            Console.WriteLine("> Informe os valores ou escolha sair.");
                            Console.WriteLine("=========================================================================");
                            Console.WriteLine("   1 = Iniciar cálculo.");
                            Console.WriteLine("   2 = Sair.");
                            Console.Write("   Escolha: ");
                            opc = int.Parse(Console.ReadLine());
                            while ((opc < 1) || (opc > 2))
                            {
                                Console.Write("--- Opção inválida. Corrija: ");
                                opc = int.Parse(Console.ReadLine());

                            }
                            if (opc == 2)
                            {
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("** Finalizando programa... [PRESSIONE QUALQUER TECLA]");
                            }
                            else
                            {
                                Console.WriteLine("=============================================================");
                                Console.Write("Base: ");
                                double bas = double.Parse(Console.ReadLine());
                                Console.Write("Expoente positivo: ");
                                int exp = int.Parse(Console.ReadLine());
                                while (exp < 0)
                                {
                                    Console.Write("Expoente inválido. Corrija: ");
                                    exp = int.Parse(Console.ReadLine());
                                }
                                i = 0;
                                result = 0;
                                if (exp == 0)
                                {
                                    result = bas;
                                }
                                else
                                {
                                    result = 1;
                                    for (i = 1; i <= exp; i++)
                                    {
                                        result = result * bas;
                                    }
                                }

                                Console.WriteLine("\n->> Resultado: " + result + "            [Pressione ENTER para próximo cálculo]");
                            }
                            Console.ReadKey();
                            Console.Clear();

                        }
                        Thread.Sleep(1000);
                        break;

                    case 7:
                        i = 0; opc = 0;
                        double valor = 0;
                        while (opc != 2)
                        {
                            Console.WriteLine("=================== CALCULAR FATORIAL ======================");
                            Console.WriteLine("- Obs: [1] Iniciar cálculo / [2] Sair.");
                            Console.WriteLine("       Informe apenas números inteiros.");
                            Console.WriteLine("       Não existe fatorial para números negativos.");
                            Console.WriteLine("\n===========================================================");
                            Console.Write(" -> [1 ou 2]: ");
                            opc = int.Parse(Console.ReadLine());
                            while ((opc < 1) || (opc > 2))
                            {
                                Console.Write("Opção inválida. Corrija: ");
                                opc = int.Parse(Console.ReadLine());
                            }
                            if (opc == 2)
                            {
                                Console.WriteLine("\nFinalizando... [PRESSIONE QUALQUER TECLA]");
                            }
                            else
                            {
                                Console.Write("\nFatorial do número: ");
                                int fat = int.Parse(Console.ReadLine());
                                while (fat < 0)
                                {
                                    Console.Write("Número inválido. Corrija: ");
                                    fat = int.Parse(Console.ReadLine());
                                }
                                if (fat == 0)
                                {
                                    Console.WriteLine("\n> RESULTADO: 1");
                                }
                                else
                                {
                                    valor = fat;
                                    for (i = (fat - 1); i >= 1; i--)
                                    {
                                        valor = (valor * i);
                                    }
                                    Console.WriteLine("\n> RESULTADO: " + valor);
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Thread.Sleep(1000);
                        break;

                    case 8:
                        Console.WriteLine("          .  .	");
                        Console.WriteLine("          |\\_|\\	");
                        Console.WriteLine("          | a_a\\	");
                        Console.WriteLine("          | |  ]\\		- PRESSIONE QUALQUER TECLA");
                        Console.WriteLine("      ____| '-\\___		- ATÉ A PROXÍMA AMIGUINHO");
                        Console.WriteLine("     /.----.___.-'\\		");
                        Console.WriteLine("    //        _    \\	");
                        Console.WriteLine("   //   .-. (~v~) /|	");
                        Console.WriteLine("  |'|  /\\:  .--  / \\		");
                        Console.WriteLine(" // |-/  \\_/____/\\/~|	");
                        Console.WriteLine("|/  \\|  []_|_|_] \\ |	");
                        Console.WriteLine("| \\  | \\ |___   _\\ ]_}	   >> FINALIZANDO CONSOLE <<");
                        Console.WriteLine("| |  '-' /   '.'  |		");
                        Console.WriteLine("| |     /    /|:  | 		");
                        Console.WriteLine("| |     |   / |:  /\\		");
                        Console.WriteLine("| |     /  /  |  /  \\	");
                        Console.WriteLine("| |    |  /  /  |    \\	");
                        Console.WriteLine("\\ |    |/\\/  |/|/\\    \\	");
                        Console.WriteLine(" \\|\\ |\\|  |  | / /\\/\\__\\	");
                        Console.WriteLine("  \\ \\| | /   | |__		");
                        Console.WriteLine("snd    / |   |____)		");
                        Console.WriteLine("       |_/			");
                        Console.ReadKey();
                        Thread.Sleep(1000);
                        break;

                }
                Console.Clear();
            }
            Thread.Sleep(500);
        }
    }
}
