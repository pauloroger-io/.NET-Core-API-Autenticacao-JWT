using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AutenticacaoJwt.Services
{
    public class JwtToken
    {
        private readonly IConfiguration _configuracao;

        public JwtToken()
        {
        }

        public JwtToken(IConfiguration configuracao)
        {
            _configuracao = configuracao;
        }

        public string GerarTokenJwt(int idUsuario)
        {
            var meuClaims = new[]
            {
                    new Claim("claimIdUsuario", idUsuario.ToString())
            };

            var key = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("0f61b1876c0ce6ca866132e8538ae0b715e132ac1ad48b392eb4d444254d606c96b"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    issuer: "www",
                    audience: "www",
                    claims: meuClaims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: creds);

            string retorno = new JwtSecurityTokenHandler().WriteToken(token);

            return retorno;
        }
    }
}
