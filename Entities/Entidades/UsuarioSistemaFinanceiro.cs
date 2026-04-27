using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{

    [Table("UsuarioSistemaFinanceiro")]
    public class UsuarioSistemaFinanceiro
    {
        public int Id { get; set; }

        public string EmailUsuario { get; set; }
        public int Administrador { get; set; }
        public int SistemaAtual { get; set; }

        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}
