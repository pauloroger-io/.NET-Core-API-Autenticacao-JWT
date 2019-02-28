using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutenticacaoJwt.Model.DTOs;

namespace AutenticacaoJwt.Model
{
    public class Usuario
    {
        public DtoUsuario ObterUsuarioPorEmail(DtoUsuario crendenciaisInformadas)
        {
            try
            {
                DtoUsuario usuario = new DtoUsuario();
                var bancoFake = BancoFake();

                usuario = bancoFake.Where(x => 
                         x.email == crendenciaisInformadas.email
                         && x.usuario == crendenciaisInformadas.usuario
                         && x.senha == crendenciaisInformadas.senha).FirstOrDefault();

                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DtoUsuario> BancoFake()
        {
            try
            {
                List<DtoUsuario> TBUSUARIOS = new List<DtoUsuario>();

                DtoUsuario usuario1 = new DtoUsuario();
                usuario1.idUsuario = 1000;
                usuario1.email = "fd98fda89fda79f8da798ffds7fdsh79da@gmail.com";
                usuario1.usuario = "fd98fda89fda79f8da798ffds7fdsh79da";
                usuario1.senha = "fd98fda89fda79f8da798ffds7fdsh79daSenha";
                TBUSUARIOS.Add(usuario1);

                DtoUsuario usuario2 = new DtoUsuario();
                usuario2.idUsuario = 2000;
                usuario2.email = "lfkdajfdaslkjçfdafaslkjfdasfklasçjfa@gmail.com";
                usuario2.usuario = "lfkdajfdaslkjçfdafaslkjfdasfklasçjfa";
                usuario2.senha = "lfkdajfdaslkjçfdafaslkjfdasfklasçjfaSenha";
                TBUSUARIOS.Add(usuario2);

                DtoUsuario usuario3 = new DtoUsuario();
                usuario3.idUsuario = 3000;
                usuario3.email = "dasfkfdsfadfklafnfsajfdasnfdsahfdasfn23f26@gmail.com";
                usuario3.usuario = "dasfkfdsfadfklafnfsajfdasnfdsahfdasfn23f26";
                usuario3.senha = "dasfkfdsfadfklafnfsajfdasnfdsahfdasfn23f26Senha";
                TBUSUARIOS.Add(usuario3);

                return TBUSUARIOS;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
