using Aula2305_EF_DBF.Models;
using Aula2305_EF_DBF.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2305_EF_DBF.Views.Categoria
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //contexto (referencia paa o banco de dados)
            LojaDBEntities contexto = new LojaDBEntities();

            gvCategorias.DataSource =
                contexto.Categoria.ToList();

            gvCategorias.DataBind();

        }
    }
}