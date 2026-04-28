using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfacesServicos
{
    public interface ICategoriaServico
    {
        Task AdicionarCategoria(Categoria categoria);   // o nome da model
        Task AtualizarCategoria(Categoria categoria);   // o nome da model
    }
}
