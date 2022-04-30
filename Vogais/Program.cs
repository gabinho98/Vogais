using System;

namespace Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra de A a Z");
            char letra = char.Parse(Console.ReadLine());

            char a = 'a';
            char e = 'e';
            char i = 'i';
            char o = 'o';
            char u = 'u';

            

            if (letra == a)
            {
                Console.WriteLine("Você digitou uma vogal.");

            }
            else if(letra == e)
            {
                Console.WriteLine("Você digitou uma vogal.");
            }
            else if (letra == i)
            {
                Console.WriteLine("Você digitou uma vogal.");
            }
            else if (letra == o)
            {
                Console.WriteLine("Você digitou uma vogal.");
            }
            else if (letra == u)
            {
                Console.WriteLine("Você digitou uma vogal.");
            }
            else
            {
                Console.WriteLine("Você digitou uma Consoante.");
            }

            









        }
    }
}
