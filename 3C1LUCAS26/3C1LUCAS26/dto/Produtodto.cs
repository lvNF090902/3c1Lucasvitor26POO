using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1LUCAS26.dto
{
    class Produtodto
    {
        private string _Nome;
        private double _Preco;
        private int _Codg_barras;
        private int _Quantidade;

        public string Nome { get => _Nome; set => _Nome = value; }
        public double Preco { get => _Preco; set => _Preco = value; }
        public int Codg_barras { get => _Codg_barras; set => _Codg_barras = value; }
        public int Quantidade { get => _Quantidade; set => _Quantidade = value; }
    }
}
