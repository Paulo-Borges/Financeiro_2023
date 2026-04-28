using Domain.Interfaces.ICategoria;
using Domain.Interfaces.InterfacesServicos;
using Entities.Entidades;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class CategoriaServico : ICategoriaServico
    {

        //pra conectar ao banco pela Interface 
        private readonly InterfaceCategoria _interfaceCategoria;

        //Construtor 
        public CategoriaServico(InterfaceCategoria interfaceCategoria)
        {
            _interfaceCategoria = interfaceCategoria;
        }
        public async Task AdicionarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidarPropriedadeString(categoria.Nome, "Nome");   // Valida o nome, o metodo ValidarPropreidadeString que esta dentro de notifica
            if (valido)
                await _interfaceCategoria.Add(categoria);     // se valido adiciona categoria
        }

        public async Task AtualizarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidarPropriedadeString(categoria.Nome, "Nome");
            if (valido)
                await _interfaceCategoria.Update(categoria);
        }
    }
}
