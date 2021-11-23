using System;
using System.Collections.Generic;
using JitResidencial.Domain.Enum;
using JitResidencial.Domain.Identity;

namespace JitResidencial.Domain.Models
{
    public class Produto

    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string CodigoBarras { get; set; }
        public string NomeProduto { get; set; }
        public string Volume { get; set; }
        public string DataValidade { get; set; }
        public string DataInclusao { get; set; }
        public string DataAlteracao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public Categoria Categoria { get; set; }
        public string ImagemURL { get; set; }
    }
}
