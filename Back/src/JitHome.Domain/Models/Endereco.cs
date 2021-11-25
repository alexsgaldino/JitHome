using System;
using System.Collections.Generic;
using JitHome.Domain.Models.Identity;

namespace JitHome.Domain.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}