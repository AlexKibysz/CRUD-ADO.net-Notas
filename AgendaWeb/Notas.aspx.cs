using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using AgendaBussiness;

namespace AgendaWeb
{
    public partial class Notas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillNotasGrid();
            }
        }

        private void FillNotasGrid()
        {
            List<Entidades.Notas> ListaNotas = new List<Entidades.Notas>();

            AgendaBussiness.AgendaBussiness notabiz = new AgendaBussiness.AgendaBussiness();

            ListaNotas = notabiz.GetNotas();

            gridNotasList.DataSource = ListaNotas;

            gridNotasList.DataBind();
        }

        protected void gridNotasList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }

        protected void btn_crear_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevaNota.aspx");
        }

        protected void btn_editar_Click(object sender, EventArgs e)
        {
            string idNota = null;
            if (gridNotasList.SelectedIndex != -1)
            {
                idNota = gridNotasList.SelectedRow.Cells[0].Text;
                Response.Redirect("EditarNota.aspx?idnota=" + idNota);
            }
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            int idnota = 0;

            if (gridNotasList.SelectedIndex != -1)
            {
                idnota = Convert.ToInt32(gridNotasList.SelectedRow.Cells[0].Text);
                AgendaBussiness.AgendaBussiness notabiz = new AgendaBussiness.AgendaBussiness();
                notabiz.DeleteNota(idnota);
                FillNotasGrid();
            }
        }
    }
}