using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entidades;

namespace AgendaBussiness
{
    public class AgendaBussiness
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;

        public NotasDal notas = new NotasDal();

        public List<Notas> GetNotas()
        {
            return notas.GetNotas(connectionString);
        }

        public Notas getNotaData(int idnota)
        {
            return notas.GetNotasData(connectionString, idnota);
        }

        public void editarNota(Notas nota)
        {
            notas.EditarNotas(connectionString, nota);
        }

        public void crearNota(Notas nota)
        {
            notas.CrearNotas(connectionString, nota);
        }

        public void DeleteNota(int idnota)
        {
            notas.DeleteNotas(connectionString, idnota);
        }
    }
}