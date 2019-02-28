using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutenticacaoJwt.Model.DTOs
{
    public class DtoUsuario
    {
        public int idUsuario { get; set; }

        [Required(ErrorMessage = "Por favor, informe o email")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string email { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do usuário")]
        [MinLength(5, ErrorMessage = "O nome de usuário deve conter no mínimo 5 caracteres")]
        public string usuario { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha")]
        [MinLength(5, ErrorMessage = "A senha deve conter no mínimo 5 caracteres")]
        public string senha { get; set; }
    }
}
