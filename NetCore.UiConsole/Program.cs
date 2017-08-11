using System;

namespace NetCore.UiConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa{
                Id = 1,
                Nome = "Luiz Ricardo",
                Data = DateTime.Now
            };

            Console.WriteLine($"Hello #{pessoa.Id} {pessoa.Nome}'s World, now {pessoa.Data.ToString()}!");
            Console.ReadKey();
        }
    }
}
