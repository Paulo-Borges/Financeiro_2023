using Domain.Interfaces.Generics;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfacesServicos
{
    public interface ISistemaFinanceiroServico 
    {
        Task AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);     // o nome da model
        Task AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);     // o nome da model
    }
}
