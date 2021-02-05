using System;
using OsMobile.DBOsMobile.Models;

namespace OsMobile.DBOsMobile.Interface
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        bool Existe(int usuarioId);

        Usuario SelecioneUsuario(int usuarioId);

        void ResetDataBase();
    }
}
