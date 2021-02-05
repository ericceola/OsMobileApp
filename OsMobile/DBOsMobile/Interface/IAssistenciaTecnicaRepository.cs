using System;
using OsMobile.DBOsMobile.Models;

namespace OsMobile.DBOsMobile.Interface
{
    public interface IAssistenciaTecnicaRepository : IRepositoryBase<AssistenciaTecnica>
    {
        bool Existe(int usuarioId);

        AssistenciaTecnica SelecioneAssistencia(int usuarioId);

        void ResetDataBase();
    }
}
