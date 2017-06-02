using AdotaPet.Controllers;
using AdotaPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdotaPet.Views.Categorias
{
    public partial class CadastroCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Session["Porte"] = txtPorte.Text;

            CategoriasControllers ctrl = new CategoriasControllers();

            Categoria cat = new Categoria();

            cat.Porte = Session["Porte"].ToString();

            ctrl.Adicionar(cat);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPorte.Text = String.Empty;
        }
    }
}