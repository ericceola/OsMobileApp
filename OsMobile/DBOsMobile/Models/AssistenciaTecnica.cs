using System;
using SQLite;

namespace OsMobile.DBOsMobile.Models
{
    public class AssistenciaTecnica
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Cnpj { get; set; }

        public byte Logo { get; set; }



    }
}
