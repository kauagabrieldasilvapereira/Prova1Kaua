using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Prova1Kaua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            Console.WriteLine("=======Menu=======");
            Console.WriteLine("\nExercicio 1");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Exercicio 6");
            Console.WriteLine("Exercicio 7");
            exercicio = int.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 1:
                    int n, result;
                    Console.WriteLine("Digite um numero");
                    n = int.Parse(Console.ReadLine());

                    if (n < 0)
                    {
                        result = n * -1;
                        Console.WriteLine(result);
                    }
                    else
                        Console.WriteLine(n);
                    break;

                case 2:
                    int num1;
                    Console.WriteLine("Digite um numero inteiro");
                    num1 = int.Parse(Console.ReadLine());

                    if (((num1 % 3) == 0) && ((num1 % 5) == 0))
                        Console.WriteLine("Seu número é divisel por 3 e 5");
                    else if (((num1 % 4) == 0) && ((num1 % 7) == 0))
                        Console.WriteLine("Seu número é divisel por 4 e 7");
                    else if ((num1 % 3) == 0)
                        Console.WriteLine("Seu número é divisel por 3");
                    else if ((num1 % 4) == 0)
                        Console.WriteLine("Seu número é divisel por 4");
                    else if ((num1 % 5) == 0)
                        Console.WriteLine("Seu número é divisel por 5");
                    else if ((num1 % 7) == 0)
                        Console.WriteLine("Seu número é divisel por 7");
                    else
                        Console.WriteLine("Seu numero nao e divisel nem por 3 nem por 4, nem por 5 e nem por 7");
                    break;

                case 3:
                    int n1, n2, n3;
                    Console.WriteLine("Digite um numero inteiro");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite mais um numero inteiro");
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite um ultimo numero");
                    n3 = int.Parse(Console.ReadLine());

                    if ((n1 > n2) && (n1 > n3))
                        Console.WriteLine(n1);
                    else if ((n2 > n1) && (n2 > n3))
                        Console.WriteLine(n2);
                    else
                        Console.WriteLine(n3);

                    break;

                case 4:
                    int dia;
                    Console.WriteLine("Escolha um dia da semana");
                    Console.WriteLine("1 - Domingo");
                    Console.WriteLine("2 - Segunda - Feira");
                    Console.WriteLine("3 - Terça - Feira");
                    Console.WriteLine("4 - Quarta - Feira");
                    Console.WriteLine("5 - Quinta - Feira");
                    Console.WriteLine("6 - Sexta - Feira");
                    Console.WriteLine("7 - Sabado");
                    dia = int.Parse(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("Aos domingos eu trabalho na parte da manha");
                            break;
                        case 2:
                            Console.WriteLine("As aulas de segunda são \nFilosofia \nPortugues \nMatematica");
                            break;
                        case 3:
                            Console.WriteLine("As aulas de terça são \nQuimica \nHistoria \nIngles para o mundo da informatica");
                            break;
                        case 4:
                            Console.WriteLine("As aulas de quarta são \nBiologia \nPortugues \nProgramação ;)");
                            break;
                        case 5:
                            Console.WriteLine("As aulas de quinta são \nFisica \nRedes \nSociologia");
                            break;
                        case 6:
                            Console.WriteLine("As aulas de sexta são \nGeografia \nMatematica \n Banco de dados");
                            break;
                        case 7:
                            Console.WriteLine("Aos sabados eu trabalho o dia todo");
                            break;
                        default:
                            Console.WriteLine("Dia inserido invalido");
                            break;
                    }

                    break;

                case 5:

                    int menor = 0, maior = 0;

                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine("\nInforme um número");
                        int ns6 = int.Parse(Console.ReadLine());

                        if (i == 0)
                        {
                            menor = ns6;
                            maior = ns6;
                        }

                        else if (ns6 > maior) maior = ns6;
                        else if (ns6 < menor) menor = ns6;
                    }


                    Console.WriteLine("\nMenor número informado: {0}\nMaior número informado: {1}", menor, maior);
                    break;



                    case 6:

                    float numPerfe, result6 = 0;
                    Console.WriteLine("Digite um numero para verificar se ele é perfeito");
                    numPerfe = float.Parse(Console.ReadLine());

                    for (int i = 1; numPerfe > i; i++)
                    {
                        if (numPerfe % i == 0)
                            result6 += i;
                    }
                    if(numPerfe == result6)
                        {
                        Console.WriteLine("Seu numero é perfeito");
                    }
                        else
                        Console.WriteLine("Seu numero não é perfeito");
                    break;

                case 7:
                    int somaPesoAvaliacoes = 0, totalAvaliacoes, pesoAvaliacao;

                    Console.WriteLine("Informe o total de avaliações do bimestre:");
                    totalAvaliacoes = int.Parse(Console.ReadLine());

                    if (totalAvaliacoes <= 0)
                        Console.WriteLine("Número de avaliações inválido!");

                    for (int i = 0; i < totalAvaliacoes; i++)
                    {
                        Console.WriteLine("Informe o peso da avalição {0}", i + 1);
                        pesoAvaliacao = int.Parse(Console.ReadLine());

                        somaPesoAvaliacoes += pesoAvaliacao;
                    }

                    if (totalAvaliacoes ==  3)
                    {
                        somaPesoAvaliacoes = totalAvaliacoes / 3;
                        Console.WriteLine("A média Aritimetica é {0}",somaPesoAvaliacoes);
                    }
                    else 
                        Console.WriteLine("Peso invalido");
                    break;

                default:
                    Console.WriteLine("Exercicio invalido");
                    break;
            }
        }
    }
}


