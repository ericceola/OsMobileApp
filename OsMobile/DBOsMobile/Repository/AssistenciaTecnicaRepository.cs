using System;
using OsMobile.DBOsMobile.Interface;
using OsMobile.DBOsMobile.Models;

namespace OsMobile.DBOsMobile.Repository
{
    public class AssistenciaTecnicaRepository : RepositoryBase<AssistenciaTecnica>, IAssistenciaTecnicaRepository
    {

        public bool Existe(int usuarioId)
        {
            bool exist = false;
            try
            {
                var oAssistencia = connect.Table<AssistenciaTecnica>().Where(p => p.UsuarioId == usuarioId).FirstOrDefault();

                if (oAssistencia == null)
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

        public AssistenciaTecnica SelecioneAssistencia(int usuarioId)
        {
            var oUsuario = connect.Table<AssistenciaTecnica>().Where(p => p.UsuarioId == usuarioId).FirstOrDefault();

            return oUsuario;
        }

        public void ResetDataBase()
        {
            connect.DropTable<AssistenciaTecnica>();
            connect.Dispose();

        }
    }
}

