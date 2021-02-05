using System;
using SQLite;

namespace OsMobile.DBOsMobile.Models
{
    public class Usuario
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Token { get; set; }


    }
}
