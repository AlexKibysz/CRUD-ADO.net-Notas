using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgendaWeb
{
    public partial class EditarNota : System.Web.UI.Page
    {
        private int idNota = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idNota"] != "")
                idNota = Convert.ToInt16(Request.QueryString["idNota"]);
            else
                Response.Redirect("Notas.aspx");

            if (!IsPostBack)
            {
                FillNotaData();
            }
        }

        private void FillNotaData()
        {
            AgendaBussiness.AgendaBussiness Notabiz = new AgendaBussiness.AgendaBussiness();

            Entidades.Notas nota = new Entidades.Notas();

            nota = Notabiz.getNotaData(idNota);

            this.txtDescripcion.Text = nota.mensaje;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            AgendaBussiness.AgendaBussiness NotaBiz = new AgendaBussiness.AgendaBussiness();

            Entidades.Notas nota = new Entidades.Notas();
            nota.idNotas = this.idNota;

            nota.mensaje = this.txtDescripcion.Text;

            NotaBiz.editarNota(nota);

            // mostrar mensaje
            Response.Redirect("Notas.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            // mostrar mensaje
            Response.Redirect("Notas.aspx");
        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Notas.aspx");
        }
    }
}