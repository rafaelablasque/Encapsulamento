using System.Runtime.CompilerServices;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            c.Acelerar();

            c.Acelerar();

            c.Acelerar();

            c.Frear();

            c.Frear();

            c.Acelerar();
        }
    }
}