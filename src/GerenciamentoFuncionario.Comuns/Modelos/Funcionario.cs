using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.Comuns.Modelos
{
    class Funcionario
    {
        public int Id { get; protected set; }

        public string NomeCompleto { get; protected set; }

        public  int CargoId { get; protected set; }

        public bool EbebedorCafe { get; protected set; }

        public string PrimeiroNome { get; protected set; }

        public string UltimoNome { get; protected set; }

        public DateTimeOffset DataEntrada { get; protected set; }





    }
}
