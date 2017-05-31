using Aula2505.Controllers;
using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.Views.Categorias
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriasControllers ctrl = new CategoriasControllers();

            gvCategorias.DataSource = ctrl.Listar();

            gvCategorias.DataBind();
        }
    }
}