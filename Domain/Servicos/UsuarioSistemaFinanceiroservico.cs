using Domain.Interfaces.InterfacesServicos;
using Domain.Interfaces.ISistemaFinanceiro;
using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class UsuarioSistemaFinanceiroservico : IUsuarioSistemaFinanceiroServico
    {

        private readonly InterfaceUsuarioSistemaFinanceiro _interfaceUsuarioSistemaFinanceiro;

        public UsuarioSistemaFinanceiroservico(InterfaceUsuarioSistemaFinanceiro interfaceUsuarioSistemaFinanceiro)
        {
            _interfaceUsuarioSistemaFinanceiro = interfaceUsuarioSistemaFinanceiro;
        }
        public async Task CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
        {


                await _interfaceUsuarioSistemaFinanceiro.Add(usuarioSistemaFinanceiro);
            
        }
    }
}
