
using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        public void AtualizaCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void AtualizaFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cargo> CarregaCargos()
        {
            return new List<Cargo> {
                new Cargo(1, "Desenvolvedor"),
                new Cargo(1, "Engenheiro"),
                new Cargo(1, "Arquiteto"),
                new Cargo(1, "Gerente de Projetos"),
            };
        }

        public IEnumerable<Funcionario> CarregaFuncionarios()
        {
            return new List<Funcionario> {
                new Funcionario(1, "Fulano de Tal", 1, false),
                new Funcionario(1, "Fulano de Tal", 1, true),
                new Funcionario(1, "Fulano de Tal", 1, true),
            };
        }

        public void ExcluiCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Cargo RecuperaCargoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Funcionario RecuperaFuncionarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void SalvaCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void SalvaFuncionario(Funcionario funcionario)
        {
            





        }
    }
}
