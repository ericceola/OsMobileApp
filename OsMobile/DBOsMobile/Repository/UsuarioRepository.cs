using System;
using OsMobile.DBOsMobile.Interface;
using OsMobile.DBOsMobile.Models;

namespace OsMobile.DBOsMobile.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public bool Existe(int usuarioId)
        {
            bool exist = false;
            try
            {
                var oUsuario = connect.Table<Usuario>().Where(p => p.UsuarioId == usuarioId).FirstOrDefault();

                if (oUsuario == null)
                {
                    exist = false;
                }
                else
                {
                    exist = true;
                }
                return exist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario SelecioneUsuario(int usuarioId)
        {
            var oUsuario = connect.Table<Usuario>().Where(p => p.UsuarioId == usuarioId).FirstOrDefault();

            return oUsuario;
        }

        public void ResetDataBase()
        {
            connect.DropTable<Usuario>();
            connect.Dispose();

        }
    }
}
