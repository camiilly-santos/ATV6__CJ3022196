namespace ATV6_CJ3022196
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            Console.WriteLine("Escolha um exercício: ");
            Console.WriteLine("Digite 1 para 1");
            Console.WriteLine("Digite 2 para 2");
            Console.WriteLine("Digite 3 para 3");
            Console.WriteLine("Digite 4 para 4");
            Console.WriteLine("Digite 5 para 5");
            Console.WriteLine("Digite 6 para 6");
            Console.WriteLine("Digite 7 para 7");
            exercicio = int.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 1:
                    {
                        Console.WriteLine("Digite um número inteiro:");
                        int numero = int.Parse(Console.ReadLine());

                        int contador = 1;
                        while (contador <= numero)
                        {
                            Console.WriteLine(contador);
                            contador++;
                        }

                        Console.ReadLine(); 
                    }
                    break;
            
                case 2:
                    {
                        Console.WriteLine("Digite um número inteiro:");
                        int numero = int.Parse(Console.ReadLine());

                        int contador = 1;
                        Console.WriteLine("Números pares até " + numero + ":");

                        while (contador <= numero)
                        {
                            if (contador % 2 == 0)
                            {
                                Console.WriteLine(contador);
                            }
                            contador++;
                        }

                        Console.ReadLine(); 
                    }
                    break;
            
                case 3:

                    {
                        int limite = 1000;
                        int numero;

                        do
                        {
                            Console.WriteLine("Digite um número inteiro menor que 1000:");
                            numero = int.Parse(Console.ReadLine());

                            if (numero >= limite)
                            {
                                Console.WriteLine("O número informado não é menor que 1000. Tente novamente.");
                            }
                        } while (numero >= limite);

                        Console.WriteLine("Números pares de 1000 até " + numero + ":");

                        int contador = 1000;
                        while (contador <= numero)
                        {
                            if (contador % 2 == 0)
                            {
                                Console.WriteLine(contador);
                            }
                            contador++;
                        }

                        Console.ReadLine(); // Para manter a janela do console aberta
                    }
                    break;

                case 4:
                    {
                        int somaPositivos = 0;

                        Console.WriteLine("Digite uma sequência de números inteiros (digite 0 para parar):");

                        while (somaPositivos < 200)
                        {
                            Console.Write("Digite um número: ");
                            int numero = int.Parse(Console.ReadLine());

                            if (numero == 0)
                            {
                                break; // Se o número digitado for zero, interrompe o loop
                            }

                            if (numero > 0)
                            {
                                Console.WriteLine("Número positivo: " + numero);
                                somaPositivos += numero;
                            }
                        }

                        Console.WriteLine("Soma dos números positivos: " + somaPositivos);
                        Console.ReadLine();
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Digite um número inteiro:");
                        int numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Divisores de " + numero + ":");

                        int divisor = 1;
                        while (divisor <= numero)
                        {
                            if (numero % divisor == 0)
                            {
                                Console.WriteLine(divisor);
                            }
                            divisor++;
                        }

                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {


                        {
                            int contador = 1;
                            int maior = int.MinValue;
                            int menor = int.MaxValue;

                            Console.WriteLine("Digite 10 números:");

                            while (contador <= 10)
                            {
                                Console.Write("Número " + contador + ": ");
                                int numero = int.Parse(Console.ReadLine());

                                if (numero > maior)
                                {
                                    maior = numero;
                                }

                                if (numero < menor)
                                {
                                    menor = numero;
                                }

                                contador++;
                            }

                            Console.WriteLine("O maior número digitado foi: " + maior);
                            Console.WriteLine("O menor número digitado foi: " + menor);
                            Console.ReadLine();
                            break;
                        }
                    
                    }
                case 7:
                    {
                        int somaPares = 0;
                        int somaImpares = 0;

                        Console.WriteLine("Digite uma sequência de números (digite 0 para parar):");

                        int numero;
                        do
                        {
                            Console.Write("Digite um número: ");
                            numero = int.Parse(Console.ReadLine());

                            if (numero % 2 == 0)
                            {
                                somaPares += numero;
                            }
                            else
                            {
                                somaImpares += numero;
                            }
                        } while (numero != 0);

                        Console.WriteLine("Soma dos números pares: " + somaPares);
                        Console.WriteLine("Soma dos números ímpares: " + somaImpares);
                        Console.ReadLine();
                        break;
                    }
            }
        }
            }


        }







        
    
