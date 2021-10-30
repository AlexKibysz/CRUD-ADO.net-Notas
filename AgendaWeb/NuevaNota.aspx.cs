using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgendaWeb
{
    public partial class NuevaNota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            AgendaBussiness.AgendaBussiness NotaBiz = new AgendaBussiness.AgendaBussiness();

            Entidades.Notas nota = new Entidades.Notas();

            nota.mensaje = this.txtDescripcion.Text;

            nota.fechaEscritura = DateTime.Now;

            nota.fechaEntrega = fechaEntregaCalendario.SelectedDate;

            NotaBiz.crearNota(nota);

            // mostrar mensaje
            Response.Redirect("Notas.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            // mostrar mensaje
            Response.Redirect("Notas.aspx");
        }
    }
}