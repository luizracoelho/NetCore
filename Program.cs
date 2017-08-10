using System;
using Teste;

namespace testenetcore
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa{
                Nome = "Luiz Ricardo"
            };
            Console.WriteLine($"Hello {pessoa.Nome}'s World!");
        }
    }
}
