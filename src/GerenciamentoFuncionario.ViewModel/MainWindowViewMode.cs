using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionario.WinUI
{
    class MainWindowViewModel(IFuncionarioProvedorDados funcionarioProvedorDados)
    {

        _funcionarioProvedorDados = funcionarioProvedorDados;

    }
}
