﻿using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos.Usuario
{
    public class CreateUsariosDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, Compare("Password")]
        public string RePassword { get; set; }
    }
}
