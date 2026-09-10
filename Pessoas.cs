using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Pessoas
    {
        private string _nome;

        public string Nome { 
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(vaule))
                {
                    Console.WriteLine("Não Reconhecido");
                }
                else
                {
                    _nome = value;
                }
            }
        }
    }
}
